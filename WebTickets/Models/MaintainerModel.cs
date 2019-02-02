
namespace WebTickets
{

    using SquirrelFramework.Domain.Model;
    [Collection("Maintainer")]
    public class MaintainerModel : UserModel
    {
        public string SkillScore { get; set; }//技术评分
        public string Speciality { set; get; }//特长
    }
}
