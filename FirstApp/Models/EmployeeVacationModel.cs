// Ignore Spelling: Strat App

namespace FirstApp.Models
{
    public class EmployeeVacationModel
    {
        public EmployeeVacationModel()
        {
            TbEmployee = new EmployeesModel();
        }

        public int EmployeeVacationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int VacationType { get; set; }
        public string Description { get; set; } = string.Empty;
        public int EmployeeId { get; set; }
        public EmployeesModel TbEmployee { get; set; }
    }
}
