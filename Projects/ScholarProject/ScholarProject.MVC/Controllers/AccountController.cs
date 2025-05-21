using Microsoft.AspNetCore.Mvc;
using ScholarProject.BL.Services;
using ScholarProject.BL.ViewModels;

namespace ScholarProject.MVC.Controllers;

public class AccountController : Controller
{
    private readonly AccountService _accountService;

    public AccountController(AccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(AccountCreateVM accountCreateVM)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        string result = await _accountService.RegisterAsync(accountCreateVM);
        if (result != "OK")
        {
            ModelState.AddModelError(string.Empty, result);
            return View();
        }
        return RedirectToAction(nameof(Login));
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(AccountLoginVM accountLoginVM)
    {

        string result = await _accountService.LoginAsync(accountLoginVM);
        if (result != "OK")
        {
            ModelState.AddModelError(string.Empty, result);
            return View();
        }
        return RedirectToAction(nameof(Index), "Home");
    }
}
