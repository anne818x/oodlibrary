using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OODLibrary
{
    class Borrowed
    {
        private string connection = "datasource=localhost;database=oodlibrary;port=;username=root;password=";

        MySqlConnection MyConn;
        
        //Adding a item to the borrowed table 
        public void addBorrow(string IDMember, string IDBook, string IDCD, string IDTape)
        {
            MyConn = new MySqlConnection(connection);

            string query1 = "INSERT INTO borrow (IDMember,IDBook,IDCD,IDTape,StartDate) VALUES(" + IDMember + "," + IDBook + "," + IDCD + "," + IDTape + "," + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }

        //changing the availability of the book to no in the book table
        public void setBookBorrowedNotAvailable(String bookId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "UPDATE books SET Availability = 'No' WHERE IDBook = " + "'" + bookId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }
        //changing the availability of the cd to no in the cd table
        public void setCDBorrowedNotAvailable(String cdId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "UPDATE cd SET Availability = 'No' WHERE IDCD = " + "'" + cdId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }
        //changing the availability of the tape to no in the tape table
        public void setTapeBorrowedNotAvailable(String tapeId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "UPDATE videotape SET Availability = 'No' WHERE IDTape = " + "'" + tapeId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }
    }
}
