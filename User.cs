using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDAPP.Model
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public string DateOfBirth { get; set; }
        public decimal BasicSalary { get; set; }

    }
}
