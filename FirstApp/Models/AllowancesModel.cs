using System.ComponentModel.DataAnnotations;
namespace FirstApp.Models
{
    public class AllowancesModel
    {
        public AllowancesModel()
        {
            EmployeesAllowances = new HashSet<EmployeesAllowancesModel>();
        }

        [Key]
        public int AllowancesId { get; set; }
        public int Name { get; set; }
        public ICollection<EmployeesAllowancesModel> EmployeesAllowances { get; set; }

    }
}
