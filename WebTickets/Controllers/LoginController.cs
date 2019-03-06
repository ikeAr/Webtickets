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
    using WebTickets.Models;
    #endregion using directives
    [AllowAnonymous]
    public class LoginController : ControllerBase
    {
        UserRepo userRepo = new UserRepo();
        public ActionResult Index()
        {
            return this.View();
        }

        [ValidateAntiForgeryToken]//跨站脚本攻击
        public ActionResult Login(UserModel newUser, string returnUrl)
        {
            if (this.ModelState.IsValid)
            {
                newUser.Password = newUser.Password.ToMD5HashCode();
                var user = userRepo.Get(x => x.RuiJieId == newUser.RuiJieId);
                if (user.Password == newUser.Password)
                {
                    SetAuthCookie(user.Name, newUser.IsRememberMe, user);
                    return this.CheckReturnUrl(returnUrl)
                        ? this.Redirect(returnUrl)
                        : this.RedirectToAction("Index", "Home") as ActionResult;
                }
                this.ModelState.AddModelError("", "请检查你的用户名或密码");
            }
            return this.View("Index", newUser);
        }

        public ActionResult CheckLoginData(string ruijieId)
        {
            if ((userRepo.GetCount(x => x.RuiJieId == ruijieId) == 0) || (userRepo.Get(x => x.RuiJieId == ruijieId).AuditStatus == 0))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

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

        private static void SetAuthCookie(string userName, bool createPersistentCookie, object userData)
        {
            if (!System.Web.HttpContext.Current.Request.IsSecureConnection && FormsAuthentication.RequireSSL)
            {
                throw new HttpException("Connectin not secure creating secure cookie");
            }
            FormsAuthentication.Initialize();
            if (userName == null)
            {
                userName = string.Empty;
            }

            var cookiePath = FormsAuthentication.FormsCookiePath;
            var utcNow = DateTime.UtcNow;
            var expirationUtc = utcNow + FormsAuthentication.Timeout;
            var authenticationTicket = new FormsAuthenticationTicket(2, userName, utcNow.ToLocalTime(), expirationUtc.ToLocalTime(), createPersistentCookie, JsonConvert.SerializeObject(userData), cookiePath);

            var encryptedTicket = FormsAuthentication.Encrypt(authenticationTicket);
            if (string.IsNullOrEmpty(encryptedTicket))
            {
                throw new HttpException("Unable to encrypt cookie ticket");
            }

            var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket)
            {
                HttpOnly = true,
                Path = cookiePath,
                Secure = FormsAuthentication.RequireSSL
            };

            if (FormsAuthentication.CookieDomain != null)
            {
                authCookie.Domain = FormsAuthentication.CookieDomain;
            }
            if (authenticationTicket.IsPersistent)
            {
                authCookie.Expires = authenticationTicket.Expiration;
            }

            System.Web.HttpContext.Current.Response.Cookies.Add(authCookie);
        }
    }
}