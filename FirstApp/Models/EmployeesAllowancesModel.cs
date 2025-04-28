using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class EmployeesAllowancesModel
    {
        public EmployeesAllowancesModel()
        {
            TbEmployees = new EmployeesModel();
            TbAllowances = new AllowancesModel();
        }
        // ************************************** //
        [Key]
        public int EmployeesAllowancesId { get; set; }
        public int EmployeesId { get; set; }
        public int AllowancesId { get; set; }
        // ********************************** //
        public EmployeesModel TbEmployees { get; set; }
        public AllowancesModel TbAllowances { get; set; }
    }
}
