using System.ComponentModel.DataAnnotations;

namespace ScholarProject.BL.ViewModels;

public class AccountCreateVM
{
    public string Fullname { get; set; }
    [EmailAddress]
    public string EmailAddress { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}
