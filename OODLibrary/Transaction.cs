using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace OODLibrary
{
    class Transaction
    {
        private string transactions;
        private string connection = "datasource=localhost;database=oodlibrary;port=;username=root;password=";

        /// <summary>
        /// Gets all transactions
        /// </summary>
        /// <returns>string of tranactions</returns>
        public String getTransactions()
        {

            transactions = "";
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query1 = "SELECT * FROM transactions";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
                transactions += ("TransID: " + MyReader["id"].ToString() + "  Member_id: " + MyReader["c_id"].ToString() + " Amount: " + MyReader["money_transferred"].ToString() + " Type: " + MyReader["transaction_type"].ToString() + "-");
            }
            return transactions;
        }

        public double getTransTotal()
        {
            double tempTotal = 0.0;
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query1 = "SELECT * FROM transactions";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
                tempTotal += Convert.ToDouble(MyReader["money_transferred"].ToString());
            }
            return tempTotal;
        }

        /// <summary>
        /// revenue report
        /// </summary>
        public void showReport()
        {
            /*generate report to show to team*/
            ArrayList tempArray = new ArrayList();
            var Message = "";
            String transactions = getTransactions();

            foreach (String transaction in transactions.Split('-'))
            {
                Message += transaction + "\n";
            }

            Message += "Total Revenue:   " + getTransTotal().ToString();
            MessageBox.Show(Message);
        }

    }
}
