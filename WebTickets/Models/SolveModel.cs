using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTickets
{
    [Collection("Solve")]
    class SolveModel : DomainModel
    {

        public long StartRequesteTime { get; set; }
        public long EndRequesteTime { get; set; }
        public string MaintainerNumber { get; set; }//用入函数得到工作人员名字
                                                    // public string Background_Administrator_name = 

        public string GradeOfDifficulty { get; set; }//难度等级
        public string ResponseTime { get; set; }//响应时间

        public long ProcessingTime { get; set; }//处理时间


        public string Sollution { get; set; }
    }

}
