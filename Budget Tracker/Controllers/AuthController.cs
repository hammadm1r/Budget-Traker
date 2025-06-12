using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Budget_Tracker.Models;

namespace Budget_Tracker.Controllers;

public class AuthController : Controller
{
    public IActionResult Signup()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }
    
};

