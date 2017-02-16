using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation.Model
{
    class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }
    }
}
