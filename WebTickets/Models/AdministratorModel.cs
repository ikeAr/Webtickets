

namespace WebTickets
{

    using SquirrelFramework.Domain.Model;
    [Collection("Administrator")]
    public class AdministratorModel : UserModel
    {
        public string Creator { get; set; }
        public long CreateTime { get; set; }
        public string Updater { get; set; }
        public string DifficuiltyGrade { get; set; }
        public long UpdateTime { get; set; }

    }
}
