using Microsoft.AspNetCore.Identity;

namespace ScholarProject.DAL.Models;

public class AppUser : IdentityUser
{
    public string Fullname { get; set; }
}
