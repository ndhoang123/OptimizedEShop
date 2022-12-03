using Microsoft.AspNetCore.Identity;

namespace OptimizedEShop.API.Entities
{
    public class User : IdentityUser
    {
        public User() : base()
        {
        }

        public User(string userName) : base(userName)
        {
        }

        public ICollection<Ordering> Orderings { get; set; }

        [PersonalData]
        public string FullName { get; set; }
    }
}
