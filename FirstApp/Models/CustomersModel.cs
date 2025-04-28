
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
public class CustomersModel
{
    public CustomersModel()
    {
        CustomersInvoices = new HashSet<CustomersInvoicesModel>();
    }

    [Key]
    [ValidateNever]
    public int CustomerId { get; set; }
    [Required(ErrorMessage = "please Enter Customer Name")]
    [StringLength(25, ErrorMessage = "name must bee lees than 25")]
    public string CustomerName { get; set; }
    [Required(ErrorMessage = "please Enter Phone")]
    [StringLength(15, ErrorMessage = "name must bee lees than 15")]
    public string Phone { get; set; }
    [Required(ErrorMessage = "please Enter Email")]
    [StringLength(80, ErrorMessage = "name must bee lees than 80")]
    [EmailAddress(ErrorMessage = "Please Enter valid Email")]
    public string Email { get; set; }
    [Required(ErrorMessage = "please Enter Cy")]
    [StringLength(80, ErrorMessage = "name must bee lees than 80")]
    public string City { get; set; }
    [Required(ErrorMessage = "please Enter Company")]
    [StringLength(20, ErrorMessage = "name must bee lees than 20")]
    public string Company { get; set; }
    [Required(ErrorMessage = "please Enter Password")]
    [StringLength(100, ErrorMessage = "name must bee lees than 100")]
    public string Password { get; set; }
    [Required(ErrorMessage = "please Enter Password")]
    [StringLength(100, ErrorMessage = "name must bee lees than 100")]
    [Compare("Password", ErrorMessage = "Password not Confirm")]
    public string ConfirmPassword { get; set; }
    public bool Conditions { get; set; } = false;
    public ICollection<CustomersInvoicesModel> CustomersInvoices { get; set; }

}
