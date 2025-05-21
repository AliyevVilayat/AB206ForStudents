using Microsoft.AspNetCore.Identity;
using ScholarProject.BL.ViewModels;
using ScholarProject.DAL.Models;

namespace ScholarProject.BL.Services;

public class AccountService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signIngManager;
    private readonly RoleManager<AppRole> _roleManager;


    public AccountService(UserManager<AppUser> userManager, SignInManager<AppUser> signIngManager, RoleManager<AppRole> roleManager)
    {
        _userManager = userManager;
        _signIngManager = signIngManager;
        _roleManager = roleManager;
    }

    public async Task<string> RegisterAsync(AccountCreateVM accountCreateVM)
    {

        AppUser appUser = new AppUser();
        appUser.Fullname = accountCreateVM.Fullname;
        appUser.Email = accountCreateVM.EmailAddress;
        appUser.UserName = accountCreateVM.Username;

        IdentityResult result = await _userManager.CreateAsync(appUser, accountCreateVM.Password);

        if (!result.Succeeded)
        {
            string errorMessage = string.Empty;
            foreach (var error in result.Errors)
            {
                errorMessage = errorMessage + error.Description + "\n";
                return errorMessage;
            }
        }

        result = await _userManager.AddToRoleAsync(appUser, "Member");
        if (!result.Succeeded)
        {
            string errorMessage = string.Empty;
            foreach (var error in result.Errors)
            {
                errorMessage = errorMessage + error.Description + "\n";
                return errorMessage;
            }
        }

        return "OK";
    }


    public async Task<string> LoginAsync(AccountLoginVM accountLoginVM)
    {

        //User-in var olub-olmamasinin yoxlanilmasi
        AppUser? user = await _userManager.FindByEmailAsync(accountLoginVM.UsernameOrEmail) ?? await _userManager.FindByNameAsync(accountLoginVM.UsernameOrEmail);
        if (user is null)
        {

            return "Bele bir User yoxdur.";
        }


        //User-in sifresinin dogru olub-olmamasinin yoxlanilmasi
        bool isCorrectPassword = await _userManager.CheckPasswordAsync(user, accountLoginVM.Password);
        if (!isCorrectPassword)
        {
            return "Daxil edilmis sifre yanlisdir.";

        }

        //Sigin process
        await _signIngManager.SignInAsync(user, true);


        return "OK";
    }

    public async Task<string> CreateRoleAsync()
    {

        AppRole role = new AppRole()
        {
            Name = "Member",
            PropForIdentityRole = "Test"
        };

        bool result = await _roleManager.RoleExistsAsync(role.Name);
        if (result)
        {
            return "Role database daxilinde movcuddur.";
        }

        await _roleManager.CreateAsync(role);
        return "OK";
    }

}
