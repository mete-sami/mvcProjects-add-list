using Microsoft.AspNetCore.Mvc;
using AspNetMvc.Models.ORM;
namespace AspNetMvc.Controllers
{
    public class CategoryController : Controller
    {
        
        public IActionResult Add()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            return View();

        }
        
    }
}
