using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTickets
{
    using SquirrelFramework.Domain.Model;
    [Collection("Request")]
    class RequestModel : DomainModel
    {

        public String ProblemTitle { set; get; }
        public List<String> Screenshots { set; get; }//string类型的
        public String Level { set; get; }            //类型
        public String Telephone { set; get; }
        public String Location { set; get; }
        public String ExpectTime { set; get; }
        public int Condition { set; get; }       //处理状态

    }
}
