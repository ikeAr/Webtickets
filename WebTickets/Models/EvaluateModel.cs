using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTickets
{
    using SquirrelFramework.Domain.Model;
    [Collection("Evaluate")]
    class EvaluateModel : DomainModel
    {
        public String Grade { set; get; }
        public String Comment { set; get; }
    }
}
