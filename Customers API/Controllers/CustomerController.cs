using Customers_API.Dtos;
using Microsoft.AspNetCore.Mvc;


namespace Customers_API.Controllers
{
    [ApiController] // Atributo que marca que es un controlador de la API
    [Route("api/[controller]")] //Al poner controller, automaticamente toma el nombre del controlador
    public class CustomerController : Controller
    {
        //Get All
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        public async Task<IActionResult> GetCustomer()
        {
            throw new NotImplementedException();
        }
        //Get by ID}
       [HttpGet("{id}")]
       [ProducesResponseType(StatusCodes.Status200OK, Type =typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCustomer( long id)
        {
            var vacio = new CustomerDto();
            return new OkObjectResult(vacio);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<IActionResult> DeleteCustomer(long id)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CustomerDto))]
        public async Task<IActionResult> CreateCustomer(CreateCustomerDto customer)
        {
            var vacio = new CustomerDto();
            return new CreatedResult($"https://localhost:7105/api/customer/{vacio.Id}", null);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }


    }
}
