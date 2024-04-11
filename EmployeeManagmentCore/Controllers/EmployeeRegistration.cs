using DAL;
using DAL.Models;
using EmployeeManagmentCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpPost]
        public async Task<IActionResult> CreateNewEmployee([FromBody] NewEmployeeData newData)
        {
            // Here you can process the received data, for example, save it to a database
            // For now, let's just return the received data
            return Ok(newData);
        }

        public async Task<IActionResult> NewRegistration()
        {
            var countries = await GetCountrys();
            ViewBag.CountryList = countries;
            var userTypes =  LoginService.GetUserType();
            var userTypesList = new List<UserType>();
            foreach (var userType in userTypes)
            {
                userTypesList.Add(new UserType
                {
                    ID = userType.Id.ToString(),
                    Type = userType.Type
                });
            }
            ViewBag.UserType = userTypesList;
            return View(countries);
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
