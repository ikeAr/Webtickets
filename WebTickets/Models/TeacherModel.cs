using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebTickets.Models
{
    [Collection("Teacher")]
    public class TeacherModel : DomainModel
    {
        [DisplayName("姓名")]
        public string TeacherName { get; set; }
        [DisplayName("工号")]
        public string JobNumber { get; set; }
        [DisplayName("密码")]
        public string Password { get; set; }
        [DisplayName("座机")]
        public string TelePhone { get; set; }
        [DisplayName("手机号")]
        public string MobilePhone { get; set; }
        [DisplayName("角色")]
        public Role role { get; set; }
    }
}