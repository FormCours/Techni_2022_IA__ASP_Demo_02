using Demo_ASP_MVC_02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ASP_MVC_02.Controllers
{
    public class ProductController : Controller
    {
        private static IList<ProductViewModel> _Products = new List<ProductViewModel>()
        {
            new ProductViewModel()
            {
                Id = 1,
                Name = "Exemple",
                Description = "Element Hardcodé",
                Price = 3.14
            }
        };

        public IActionResult Index()
        {
            return View(_Products);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductAddViewModel productAdd)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            _Products.Add(new ProductViewModel()
            {
                Id = _Products.Select(p => p.Id).Max() + 1,
                Name = productAdd.Name,
                Description = productAdd.Description,
                Price = (double)productAdd.Price
            });

            return RedirectToAction("Index");
        }
    }
}
