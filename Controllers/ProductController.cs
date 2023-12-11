using EddiesHikingStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace EddiesHikingStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ListProducts()
        {
            // Fetch a list of products
            List<ProductModel> products = ProductData.GetProducts();

            // Return the view with the list of products
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            var product = ProductData.GetProduct(id);
            return View(product);
        }
    }

}
