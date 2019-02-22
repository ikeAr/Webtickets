using System;
namespace WebTickets
{
    using SquirrelFramework.Domain.Model;
    [Collection("Evaluate")]
    public class EvaluateModel : DomainModel
    {
        public String Grade { set; get; }
        public String Comment { set; get; }
        //creator
    }
}
