namespace WebTickets.Controllers
{
    #region using directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using WebTickets.Repo;
    using System.Security.Cryptography;
    using System.Text;
    using System.Web.Security;
    using Newtonsoft.Json;
    #endregion using directives

    [AllowAnonymous]
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult Login(UserModel newUser, string returnUrl)
        {
            if (this.ModelState.IsValid)
            { 
                newUser.Password = newUser.Password.ToMD5HashCode();
                var handler = new UserRepo();
                var user = handler.Get(x => x.RuiJieId==newUser.RuiJieId);
                if (user.Password == newUser.Password)
                {
                    FormsAuthentication.SetAuthCookie(user.Name, newUser.IsRememberMe);
                    return this.CheckReturnUrl(returnUrl)
                        ? this.Redirect(returnUrl)
                        : this.RedirectToAction("index", "Login") as ActionResult;
                }
                this.ModelState.AddModelError("", "请检查你的用户名或密码");
            }
            return this.View("Index", newUser);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return this.RedirectToAction("Index");
        }

        private bool CheckReturnUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return false;
            }
            // Make Sure the return url was not redirect to an external site.
            if (Uri.TryCreate(url, UriKind.Absolute, out var absoluteUri))
            {
                return string.Equals(
                    this.Request.Url.Host,
                    absoluteUri.Host, StringComparison.OrdinalIgnoreCase);
            }
            return url[0] == '/' && (url.Length == 1
                                     || url[1] != '/' && url[1] != '\\')
                   || url.Length > 1 && url[0] == '~' && url[1] == '/';
        }
    }
}