using LoanRecovery.Enums;

namespace LoanRecovery.ViewModels
{
    public class LoggedUserInfo
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public IList<string> AssociatedRoles { get; set; }
        //as Dynamic Roles can contain other roles too
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
