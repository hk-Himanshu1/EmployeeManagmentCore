using EmployeeManagmentCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeManagmentCore.Controllers
{
    public class EmployeeRegistration : Controller
    {
        private readonly ILogger<EmployeeRegistration> _logger;

        public EmployeeRegistration(ILogger<EmployeeRegistration> logger)
        {
            _logger = logger;
        }

        public IActionResult NewRegistration()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
