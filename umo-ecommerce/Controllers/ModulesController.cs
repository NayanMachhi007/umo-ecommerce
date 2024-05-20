using Microsoft.AspNetCore.Mvc;

namespace umo_ecommerce.Controllers
{
    public class ModulesController : Controller
    {
        public IActionResult module()
        {
            return View();
        }
    }
}
