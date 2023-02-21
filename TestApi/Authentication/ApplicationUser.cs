using Microsoft.AspNetCore.Identity;

namespace TestApi.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}
