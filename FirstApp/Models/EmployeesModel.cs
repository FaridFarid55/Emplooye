// Ignore Spelling: App img Titel

using FirstApp.CustomValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class EmployeesModel
    {
        public EmployeesModel()
        {
            TbDepartment = new DepartmentsModel();
            EmployeeVacation = new HashSet<EmployeeVacationModel>();
            TbPerson = new PersonModel();
            EmployeesAllowances = new HashSet<EmployeesAllowancesModel>();
        }

        // prosperity
        [Key]
        [ValidateNever]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public PersonModel TbPerson { get; set; }

        [Required(ErrorMessage = "Please Enter Employee Name")]
        [StringLength(25, ErrorMessage = "name must bee lees than 25")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter Titel")]
        [StringLength(10, ErrorMessage = "Titel must bee lees than 100")]
        [Compare("Name", ErrorMessage = "Employees Name and Titel not Compare")]
        public string Titel { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string imgName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Please Enter valid Email")]
        [StringLength(50, ErrorMessage = "Email must bee lees than 50")]
        [Remote(action: "VerifyEmail", controller: "Employees", ErrorMessage = "Email not found")]
        [ValidationEmail("gmail", ErrorMessage = "you must use gmail.")]
        public string Email { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
        public DepartmentsModel TbDepartment { get; set; }
        public ICollection<EmployeeVacationModel> EmployeeVacation { get; set; }
        public ICollection<EmployeesAllowancesModel> EmployeesAllowances { get; set; }
    }
}

