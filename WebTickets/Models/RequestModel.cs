using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTickets
{
    using SquirrelFramework.Domain.Model;
    using System.ComponentModel;

    [Collection("Request")]
    public class RequestModel : DomainModel
    {
        [DisplayName("问题描述")]
        public string ProblemTitle { set; get; }
        [DisplayName("锐捷提示截图")]
        public List<string> Screenshots { set; get; }//string类型的
        [DisplayName("紧急情况")]
        public String Level { set; get; }           //类型
        [DisplayName("联系电话")]
        public String Telephone { set; get; }
        [DisplayName("所在位置")]
        public String Location { set; get; }
        [DisplayName("期待处理时间")]
        public String ExpectTime { set; get; }
        [DisplayName("处理状态")]
        public int Condition { set; get; }       //处理状态

    }
}
