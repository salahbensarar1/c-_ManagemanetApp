using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApplication.Models
{
    public class Customer
    {
        public int CustCode { get; set; } // Primary Key
        public required string CustName { get; set; }
        public required string CustGender { get; set; }
        public required string CustPhone { get; set; }
        public required string CustMail { get; set; }
        public required List<Billing> Billings { get; set; }
        public Customer(int custCode, string custName, string custGender, string custPhone, string custMail)
        {
            this.CustCode = custCode;
            this.CustName = custName;
            this.CustGender = custGender;
            this.CustPhone = custPhone;
            this.CustMail = custMail;
        }

        public Customer() { CustCode = 0; }

    }
}
