using System.ComponentModel.DataAnnotations;

namespace Customers_API.Dtos
{
    public class CreateCustomerDto
    {
        [Required (ErrorMessage ="El nombre es obilgatorio")]
        public string FirstName { get; set; }
        [Required (ErrorMessage ="El apellido es requerido")]
        public string LastName { get; set; }
        [RegularExpression("^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$", ErrorMessage ="El mail no es correcto")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


    }
}
