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
        public async Task<List<CustomerDto>> GetCustomer()
        {
            throw new NotImplementedException();
        }
        //Get by ID}
       [HttpGet("{id}")]
       public async Task<CustomerDto> GetCustomer( long id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<Boolean> DeleteCustomer(long id)
        {
            throw new NotImplementedException();
        }
        [HttpPost("{id}")]
        public async Task<CustomerDto> CreateCustomer(CreateCustomerDto customer)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task<CustomerDto> UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }


    }
}
