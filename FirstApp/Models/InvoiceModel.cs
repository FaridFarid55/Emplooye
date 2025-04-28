using System.Linq.Expressions;

namespace FirstApp.Models
{
    public class InvoiceModel
    {
        public InvoiceModel()
        {
            InvoiceItems = new List<InvoiceDetails>();
            InvoiceDetails = new HashSet<InvoiceDetails>();
            CustomersInvoices = new HashSet<CustomersInvoicesModel>();
        }
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public bool HasShipping { get; set; } = false;
        public ICollection<InvoiceDetails> InvoiceDetails { get; set; }
        public List<InvoiceDetails> InvoiceItems { get; set; }

        public ICollection<CustomersInvoicesModel> CustomersInvoices { get; set; }
    }
}
