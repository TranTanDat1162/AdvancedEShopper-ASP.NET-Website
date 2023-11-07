using Microsoft.AspNetCore.Mvc;

namespace AdvancedEShopper.Controllers
{
    public class CartController : Controller
    {
        public IActionResult AddtoCart(int productId)
        {
            return View("Cart");
        }
    }
}
