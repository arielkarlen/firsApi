using Microsoft.AspNetCore.Mvc;

namespace Customers_API.Controllers
{
    [ApiController] // Atributo que marca que es un controlador de la API
    [Route("api/[controller]")] //Al poner controller, automaticamente toma el nombre del controlador
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
