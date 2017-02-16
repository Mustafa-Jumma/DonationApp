using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation.Model
{
    class DonationDetails
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal AmountNeeded { get; set; }
        public decimal AmountReceived { get; set; }
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public string AccountHolder { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Status { get; set; }
    }
}
