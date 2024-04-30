using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApplication.Models
{
    public class Billing
    {
        public Billing(Customer customer)
        {
            Customer = customer;
        }

        public int BillCode { get; set; } // Primary Key
        public DateTime BillingDate { get; set; }
        public int TotalAmount { get; set; }

        // Foreign Keys
        public int CustCode { get; set; }


        public Customer Customer { get; set; }
        public List<Item> Items { get; set; }
        public Billing(int billCode, DateTime billingDate, int totalAmount, int custCode)
        {
            this.BillCode = billCode;
            this.BillingDate = billingDate;
            this.TotalAmount = totalAmount;
            this.CustCode = custCode;
        }

        public Billing() { BillCode = 0; }

    }
}
