// Ignore Spelling: App

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class InvoiceDetails
    {
        public InvoiceDetails()
        {
            TbInvoiceDetails = new InvoiceModel();
        }
        [Key]
        [ValidateNever]
        public int InvoiceDetailId { get; set; }
        public int InvoiceId { get; set; }
        public InvoiceModel TbInvoiceDetails { get; set; }
        public int ItemId { get; set; }
        [Required(ErrorMessage = "please enter price")]
        public int Price { get; set; }
        [Required(ErrorMessage = "please enter quantity")]
        public int Quantity { get; set; }
    }
}
