using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaFacturacion.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerInvoices = new HashSet<CustomerInvoice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<CustomerInvoice> CustomerInvoices { get; set; }
    }
}
