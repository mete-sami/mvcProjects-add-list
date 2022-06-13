using AspNetMvc.Models.ORM;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspNetMvc.Controllers
{
    public class HomeController : Controller
    {
        SiemensContext siemensContext = new SiemensContext();

        [HttpGet]
        public IActionResult Index()
        {
            
            List<Suppliers> supliersList = siemensContext.Suppliers.ToList();

            return View(supliersList);
            
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            //projeye entity framework aracılığı ile
            //bir database olustur.veritabanında
            //bir supplier adında tablo olsun.
            //örnek data girilir.
            //bu tablo home görüntüle.
            var idSup=siemensContext.Suppliers.FirstOrDefault(x=>x.Id==id);

            return View(idSup);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Suppliers suppliers)
        {
            siemensContext.Suppliers.Add(suppliers);
            siemensContext.SaveChanges();

            return View();
        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            siemensContext.Add(product);
            siemensContext.SaveChanges();

            return View();
        }
        public IActionResult Products()
        {
            var products = siemensContext.Products.ToList();
            return View(products);
        }
        public IActionResult UpdateProduct(int id)
        {
            var product = siemensContext.Products.FirstOrDefault(x=>x.Id==id);
            return View();
        }
        
    }
}
