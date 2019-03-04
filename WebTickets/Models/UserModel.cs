namespace WebTickets
{
    using SquirrelFramework.Domain.Model;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using WebTickets.Models;

    [Collection("User")]
    public class UserModel : DomainModel
    {
        [DisplayName("用户名(学号或工号)")]
        [Required(ErrorMessage = "请输入用户名")]
        public string RuiJieId { get; set; }
        public string Name { get; set; }
        public string Telphone { get; set; }
        public string CollegeClass { get; set; }
        public string Gender { get; set; }
        [DisplayName("密码")]
        [Required(ErrorMessage = "请输入密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("保存密码")]
        public bool IsRememberMe { get; set; }
        public Role Role { get; set; }
        public AuditStatus AuditStatus { get; set; }
    }
}
