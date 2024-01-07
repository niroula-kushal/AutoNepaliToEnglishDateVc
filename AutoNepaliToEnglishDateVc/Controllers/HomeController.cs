using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AutoNepaliToEnglishDateVc.Models;
using AutoNepaliToEnglishDateVc.ViewModels;

namespace AutoNepaliToEnglishDateVc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(HomeIndexVm vm)
    {
        vm.From ??= DateTime.Today;
        vm.To ??= DateTime.Today;
        return View(vm);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}