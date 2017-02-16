using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using SQLite;
using Donation.Model;


namespace Donation.Model
{
    class localDatabase
    {
        SQLiteConnection connection;

        public localDatabase()
        {
            string path = DependencyService.Get<IFileHelper>().GetLocalFilePath("DonationLocaldata.db3");
            connection = new SQLiteConnection(path);
            connection.CreateTable<DonationDetails>();
        }

        public void DeleteDonation(int DonationId)
        {
            string sqlstatment = "delete from Donation where id=" + DonationId;
            connection.Execute(sqlstatment);
        }

        public void ClearAllDonations()
        {
            connection.DeleteAll<DonationDetails>();
        }

        public void AddDonation(DonationDetails donation)
        {
            connection.Insert(donation);
        }

        public void AddRange(List<DonationDetails> list)
        {
            connection.InsertAll(list);
        }

        public List<DonationDetails> GetAllDonations()
        {
            return connection.Table<DonationDetails>().ToList();
        }

        public DonationDetails GetDonationByID(int DonationID)
        {
            string sqlQuery = "SELECT * FROM [Donation] where id=" + DonationID;
            return connection.Query<DonationDetails>(sqlQuery).FirstOrDefault<DonationDetails>();
        }

        //public List<UserAccount> GetAllUserAccounts(string queryString, int branchID)
        //{
        //    string sqlQuery = "SELECT * FROM [UserAccount] where branchID=" + branchID + queryString;
        //    return connection.Query<UserAccount>(sqlQuery).ToList();
        //}

    }
}

