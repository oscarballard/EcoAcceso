using Microsoft.AspNetCore.Identity;


namespace Ecoaccess.Persistance.Identity.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cedula { get; set; }
        public string Photo { get; set; }
        public bool IsActive { get; set; }
    }
}
