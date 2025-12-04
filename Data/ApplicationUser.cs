using Microsoft.AspNetCore.Identity;

namespace SIMS.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
<<<<<<< HEAD
        public string? Name { get; set; }
=======
        public string Name { get; set; }
>>>>>>> 905b7876f8d54c8c20d55743afa6dfef9409888c
        public string? Address { get; set; }
        public DateTime? DOB { get; set; }
        public string? Avatar { get; set; }
        public string? StudentId { get; set; }

    }

}
