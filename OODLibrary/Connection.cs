using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;

namespace OODLibrary
{
    class Connection
    {

        private string books;
        private string cds;
        private string vidtapes;
        private string members;
        private string connection = "datasource=localhost;database=oodlibrary;port=;username=root;password=";
        private string borrowedBooks;
        private string borrowedCDs;
        private string borrowedTapes;
        private string reservations;
        private ArrayList currentlistofid;
      
        private string transactions;

        MySqlConnection MyConn;

        public Connection()
        {
            currentlistofid = new ArrayList();
        }
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
            currentlistofid.Clear();
            MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDBook, BookName FROM books";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            books = null;
            while (MyReader.Read())
            {
                currentlistofid.Add(MyReader["IDBook"].ToString());
                books += (MyReader["IDBook"].ToString() + " " + MyReader["BookName"].ToString() + "-");
            }
            return books;
        }

        public String getAllCDs()
        {
            currentlistofid.Clear();
            MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDCD, CDName FROM cd";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            cds = null;
            while (MyReader.Read())
            {
                currentlistofid.Add(MyReader["IDCD"].ToString());
                cds += (MyReader["IDCD"].ToString() + " " + MyReader["CDName"].ToString() + "-");
            }
            return cds;
        }

        public String getAllVidTapes()
        {
            currentlistofid.Clear();
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDTape, TapeName FROM videotape";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();

            vidtapes = null;
            while (MyReader.Read())
            {
                currentlistofid.Add(MyReader["IDTape"].ToString());
                vidtapes += (MyReader["IDTape"].ToString() + " " + MyReader["TapeName"].ToString() + "-");
            }
            return vidtapes;
        }

        public String getAllMembers()
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDMember, MemberName FROM userdata";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();

            members = null;
            while (MyReader.Read())
            {
                members += (MyReader["IDMember"].ToString() + " " + MyReader["MemberName"].ToString() + "-");
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
            MyConn = new MySqlConnection(connection);
            string query1 = "DELETE FROM userdata WHERE IDMember =" + "'" + IDMember + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();

        }

        public void addBorrow(string IDMember, string IDBook, string IDCD, string IDTape)
        {
            MyConn = new MySqlConnection(connection);
        
            string query1 = "INSERT INTO borrow (IDMember,IDBook,IDCD,IDTape,StartDate) VALUES(" + IDMember + "," + IDBook + "," + IDCD + "," + IDTape + "," + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }

        public void addMember(string name, string age)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "INSERT INTO userdata (MemberName,Age) VALUES(" + "'" + name + "'" + "," + "'" + age + "'" + ")";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }

        public String showBorrowedBooks()
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query = "SELECT books.IDBook, books.BookName, books.Type, borrow.IDBook, borrow.StartDate, borrow.EndDate FROM books INNER JOIN borrow ON books.IDBook = borrow.IDBook";
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            borrowedBooks = null;
            while (MyReader.Read())
            {
                string startDate = MyReader["StartDate"].ToString();
                string endDate = MyReader["EndDate"].ToString();
                var totalDays = (Convert.ToDateTime(endDate) - Convert.ToDateTime(startDate)).TotalDays;

                borrowedBooks += (MyReader["IDBook"].ToString() + " - " + MyReader["BookName"].ToString() + " -" + MyReader["Type"].ToString() + "- " + "lend period:" + totalDays + " days" + " - " + MyReader["StartDate"].ToString() + "/");
            }
            return borrowedBooks;
        }

        public String showBorrowedCDs()
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query = "SELECT cd.IDCD, cd.CDName, cd.Type, cd.ReleaseDate, borrow.IDCD, borrow.StartDate, borrow.EndDate FROM cd INNER JOIN borrow ON cd.IDCD = borrow.IDCD";
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            borrowedCDs = null;
            while (MyReader.Read())
            {
                string startDate = MyReader["StartDate"].ToString();
                string endDate = MyReader["EndDate"].ToString();
                var totalDays = (Convert.ToDateTime(endDate) - Convert.ToDateTime(startDate)).TotalDays;

                borrowedCDs += (MyReader["IDCD"].ToString() + " - " + MyReader["CDName"].ToString() + " -" + MyReader["Type"].ToString() + "- " + MyReader["ReleaseDate"].ToString() + " - " + "lend period:" + totalDays + " days" + " - " + MyReader["StartDate"].ToString() + "/");
            }
            return borrowedCDs;
        }

        public String showBorrowedTapes()
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query = "SELECT videotape.IDTape, videotape.TapeName, videotape.Type, borrow.IDTape, borrow.StartDate, borrow.EndDate FROM videotape INNER JOIN borrow ON videotape.IDTape = borrow.IDTape";
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            borrowedTapes = "";
            while (MyReader.Read())
            {
                string startDate = MyReader["StartDate"].ToString();
                string endDate = MyReader["EndDate"].ToString();
                var totalDays = (Convert.ToDateTime(endDate) - Convert.ToDateTime(startDate)).TotalDays;

                borrowedTapes += (MyReader["TapeName"].ToString() + " - " + MyReader["Type"].ToString() + " - " + "lend period:" + totalDays + " days" + " - " + MyReader["StartDate"].ToString() + "/");
            }
            return borrowedTapes;
        }

        public void returnBook(int bookId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "DELETE FROM borrow WHERE IDBook =" + "'" + bookId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }


        public void setBookAvailable(int bookId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "UPDATE books SET Availability = 'Yes' WHERE IDBook = " + "'" + bookId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }


        public void returnCD(int cdId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "DELETE FROM borrow WHERE IDCD =" + "'" + cdId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }

        public void setCDAvailable(int cdId)
            {
                MyConn = new MySqlConnection(connection);
                string query1 = "UPDATE cd SET Availability = 'Yes' WHERE IDCD = " + "'" + cdId + "'";
                MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
            }
  
        public void setBookBorrowedNotAvailable(String bookId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "UPDATE books SET Availability = 'No' WHERE IDBook = " + "'" + bookId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }

        public void setCDBorrowedNotAvailable(String cdId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "UPDATE cd SET Availability = 'No' WHERE IDBook = " + "'" + cdId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }

        public void setTapeBorrowedNotAvailable(String tapeId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "UPDATE videotape SET Availability = 'No' WHERE IDBook = " + "'" + tapeId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }
        public ArrayList giveCurrentSelectionids()
        {
            return this.currentlistofid;
        }
        public string getReservations(int id, string type)
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query = "SELECT * FROM reservations WHERE id=" + id.ToString() + " AND type=" + type;
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            reservations = "";
            while (MyReader.Read())
            {
                reservations = "not set yet";
            }
            return reservations;
        }

        public void placeReservation(int id, int c_id,  string type)
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query = "INSERT INTO reservations VALUES (null," + c_id + "0.5 ," + c_id.ToString() +","+type +"null)"; 
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }

    }
}
