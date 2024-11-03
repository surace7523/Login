using Microsoft.AspNetCore.Identity;

namespace SalesCRMApp.Models
{
    public class Users: IdentityUser
    {

        public string FullName { get; set; }
    }
}
