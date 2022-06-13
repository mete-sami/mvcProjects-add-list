using AspNetMvc.Models.ORM;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            return View();

        }
        
    }
}
