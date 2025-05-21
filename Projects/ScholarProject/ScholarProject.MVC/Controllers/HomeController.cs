using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ScholarProject.MVC.Controllers;

[Authorize(Roles = "Member")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
