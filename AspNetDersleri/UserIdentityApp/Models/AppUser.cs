using Microsoft.AspNetCore.Identity;

namespace UserIdentityApp.Models
{
    public class AppUser: IdentityUser{

        public string? FullName {get; set;} 
    }
    
}