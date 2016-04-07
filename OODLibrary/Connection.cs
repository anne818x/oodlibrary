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
        private string connection = "datasource=localhost;database=oodlibrary;port=;username=root;password=";
        private string borrowedBooks;
        private string borrowedCDs;
        private string borrowedTapes;
        MySqlConnection MyConn;

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
            MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDBook, BookName FROM books";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            books = null;
            while (MyReader.Read())
            {
                books += (MyReader["IDBook"].ToString() + " " + MyReader["BookName"].ToString() + "-");
            }
            return books;
        }

        public String getAllCDs()
        {

            MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDCD, CDName FROM cd";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            cds = null;
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

            vidtapes = null;
            while (MyReader.Read())
            {
                vidtapes += (MyReader["IDTape"].ToString() + " " + MyReader["TapeName"].ToString() + "-");
            }
            return vidtapes;
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
  
       
    }
}
