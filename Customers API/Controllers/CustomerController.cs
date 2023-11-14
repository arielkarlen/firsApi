using Customers_API.Dtos;
using Customers_API.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace Customers_API.Controllers
{
    [ApiController] // Atributo que marca que es un controlador de la API
    [Route("api/[controller]")] //Al poner controller, automaticamente toma el nombre del controlador
    public class CustomerController : Controller
    {

        private readonly CustomerDataBaseContext _customerDataBaseContext;

        public CustomerController(CustomerDataBaseContext customerDataBaseContext)
        { 
        _customerDataBaseContext = customerDataBaseContext;
        }
        //Get All
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<CustomerDto>))]
        public async Task<IActionResult> GetCustomer()
        {
            var result = _customerDataBaseContext.Customers
                .Select(c=>c.ToDto()).ToList();

            return new OkObjectResult(result);
        }
        //Get by ID}
       [HttpGet("{id}")]
       [ProducesResponseType(StatusCodes.Status200OK, Type =typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCustomer( long id)
        {
            CustomerEntity result = await _customerDataBaseContext.Get(id);
            return new OkObjectResult(result.ToDto());
        }
        //Delete by ID}
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<IActionResult> DeleteCustomer(long id)
        {
            var result = await _customerDataBaseContext.Delete(id);
            return new OkObjectResult(result);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CustomerDto))]
        public async Task<IActionResult> CreateCustomer(CreateCustomerDto customer)
        {
          CustomerEntity result = await _customerDataBaseContext.Add(customer);
            return new CreatedResult($"https://localhost:7105/api/customer/{result.Id}", null);
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
