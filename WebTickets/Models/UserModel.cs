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
        [DisplayName("姓名")]
        public string Name { get; set; }
        [DisplayName("手机号")]
        public string MobilePhone { get; set; }
        [DisplayName("学院班级")]
        public string CollegeClass { get; set; }
        [DisplayName("性别")]
        public string Gender { get; set; }
        [DisplayName("密码")]
        [Required(ErrorMessage = "请输入密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("保存密码")]
        public bool IsRememberMe { get; set; }
        [DisplayName("角色")]
        public Role Role { get; set; }
        public int AuditStatus { get; set; }
        [DisplayName("座机")]
        public string TelePhone { get; set; }
    }
}
