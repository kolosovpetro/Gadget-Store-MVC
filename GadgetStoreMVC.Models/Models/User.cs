using Microsoft.AspNetCore.Identity;

namespace GadgetStoreMVC.Models.Models
{
    public class User: IdentityUser
    {
        public int Year { get; set; }
    }
}
