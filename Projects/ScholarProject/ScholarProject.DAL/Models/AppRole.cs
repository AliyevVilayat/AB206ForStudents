using Microsoft.AspNetCore.Identity;

namespace ScholarProject.DAL.Models;

public class AppRole : IdentityRole
{
    public string PropForIdentityRole { get; set; }
}