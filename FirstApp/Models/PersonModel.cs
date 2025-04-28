using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class PersonModel
    {
        public PersonModel()
        {
            TbEmployees = new EmployeesModel();
        }

        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public EmployeesModel TbEmployees { get; set; }    
    }
}
