using CompanyMVCApp;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{
    private readonly CompanyDbContext _context;

    public HomeController(CompanyDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var companies = _context.Companies.ToList();
        return View(companies);
    }
}
