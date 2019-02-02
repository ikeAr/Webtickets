

namespace WebTickets
{
    using SquirrelFramework.Domain.Model;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [Collection("User")]
    public class UserModel : DomainModel
    {
        [DisplayName("Username")]
        [Required(ErrorMessage = "Please enter your username")]
        public string RuiJieId { get; set; }
        public string Name { get; set; }
        public string Telphone { get; set; }
       
        

        public string Gender { get; set; }
        public string Dormitory { get; set; }

        public string MacAddress { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Remember me")]
        public string ConfirmPassword { get; set; }
        public bool IsRememberMe { get; set; }

    }
}
