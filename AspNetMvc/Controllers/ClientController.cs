using AspNetMvc.Models.ORM;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers
{
    public class ClientController : Controller
    {
        SiemensContext siemensContext = new SiemensContext();
        public IActionResult Add()

        {

            return View();
            
        }
        [HttpPost]
        public IActionResult Add(Client client)
        {
            siemensContext.Clients.Add(client);
            siemensContext.SaveChanges();

            return View();

        }
        public IActionResult List()
        {
            var clients = siemensContext.Clients.ToList();
            return View(clients);
        }
    }
}
