using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OODLibrary
{
    class Connection
    {
        private string books;
        private string cds;
        private string vidtapes;
        private string members;
        private string connection = "datasource=localhost;database=oodlibrary;port=;username=root;password=";
        private string transactions;
        public void Connect()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connection);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public String getAllBooks()
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDBook, BookName FROM books";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
                books += (MyReader["IDBook"].ToString() + " " + MyReader["BookName"].ToString() + "-");
            }
            return books;
        }

        public String getAllCDs()
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDCD, CDName FROM cd";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
                cds += (MyReader["IDCD"].ToString() + " " + MyReader["CDName"].ToString() + "-");
            }
            return cds;
        }

        public String getAllVidTapes()
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDTape, TapeName FROM videotape";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
                 vidtapes += (MyReader["IDTape"].ToString() + " " + MyReader["TapeName"].ToString() + "-");
            }
            return vidtapes;
        }

        public String getAllMembers()
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDMember, MemberName FROM userdata";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
                members += (MyReader["IDMember"].ToString() + " " +  MyReader["MemberName"].ToString() + "-");
            }
            return members;
        }


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
                transactions += ("TransID: "+MyReader["id"].ToString() + "  Member_id: " + MyReader["c_id"].ToString() + " Amount: " +MyReader["money_transferred"].ToString() +" Type: "+ MyReader["transaction_type"].ToString()+"-");
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
        public void deleteMember(string IDMember)
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query1 = "DELETE FROM userdata WHERE IDMember =" + "'" + IDMember + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();

        }

        public void addBorrow(string IDMember, string IDCD, string IDTape, string IDBook)
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query1 = "INSERT INTO borrow (IDMember,IDCD,IDTape,IDBook,StartDate,EndDate) VALUES(" + "'" + IDMember + "'" + "," + "'" + IDCD + "'" + "," + "'" + IDTape + "'" + "," + "'" + IDBook + "'" + "," + "'" + DateTime.Now.Date + "'" + "," + "'" + DateTime.Now.Date + "'" + ")";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }

        public void addMember(string name, string age)
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query1 = "INSERT INTO userdata (MemberName,Age) VALUES(" + "'" + name + "'" +"," + "'" + age + "'" + ")";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }

    }
}
