using DAL;
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

        public async Task<IActionResult>NewRegistration()
        {
            var data = await GetCountrys();
            return View(data);
        }

        public static async Task<List<string>> GetCountrys() {

            var Countrydata = await RegistrationApi.GetCountriesData();
            return Countrydata;

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
