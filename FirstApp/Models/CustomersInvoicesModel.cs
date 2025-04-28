using System.ComponentModel.DataAnnotations;
namespace FirstApp.Models
{
    public class CustomersInvoicesModel
    {
        public CustomersInvoicesModel()
        {
            TbInvoice = new InvoiceModel();
            TbCustomer = new CustomersModel();
        }

        [Key]
        public int CustomersInvoicesModelId { get; set; }
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }

        public InvoiceModel TbInvoice { get; set; }
        public CustomersModel TbCustomer { get; set; }
    }
}
