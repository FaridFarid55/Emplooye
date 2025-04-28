namespace FirstApp.Models
{
    public class DepartmentsModel
    {
        public DepartmentsModel()
        {
            Employees = new HashSet<EmployeesModel>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public ICollection<EmployeesModel> Employees { get; set; }
    }
}
