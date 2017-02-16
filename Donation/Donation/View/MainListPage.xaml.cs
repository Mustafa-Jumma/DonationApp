using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Donation.Model;

namespace Donation
{
    public partial class MainListPage : ContentPage
    {
        public MainListPage()
        {
            InitializeComponent();

            localDatabase LocalDatabase = new localDatabase();

            var list = new List<DonationDetails>
           {
               new DonationDetails {id=1,Name="testname",Description="Description",AmountNeeded=0 ,AmountReceived=0,AccountNo="AccountNo", AccountHolder="AccountHolder",DateAdded=DateTime.Now,Status=true },
               new DonationDetails {id=2,Name="testname",Description="Description",AmountNeeded=0 ,AmountReceived=0,AccountNo="AccountNo", AccountHolder="AccountHolder",DateAdded=DateTime.Now,Status=true },
               new DonationDetails {id=3,Name="testname",Description="Description",AmountNeeded=0 ,AmountReceived=0,AccountNo="AccountNo", AccountHolder="AccountHolder",DateAdded=DateTime.Now,Status=true },
               new DonationDetails {id=4,Name="testname",Description="Description",AmountNeeded=0 ,AmountReceived=0,AccountNo="AccountNo", AccountHolder="AccountHolder",DateAdded=DateTime.Now,Status=true },
               new DonationDetails {id=5,Name="testname",Description="Description",AmountNeeded=0 ,AmountReceived=0,AccountNo="AccountNo", AccountHolder="AccountHolder",DateAdded=DateTime.Now,Status=true },
           };

            LocalDatabase.AddRange(list);
            lstDonations.ItemsSource = LocalDatabase.GetAllDonations();
        }
    }
}
