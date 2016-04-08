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
        private string books;
        private string cds;
        private string vidtapes;


        //Adding a item to the borrowed table 
        public void addBorrow(string IDMember, string IDBook, string IDCD, string IDTape)
        {
            MyConn = new MySqlConnection(connection);

            string query1 = "INSERT INTO borrow (IDMember,IDBook,IDCD,IDTape,StartDate) VALUES(" + IDMember + "," + IDBook + "," + IDCD + "," + IDTape + "," + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            //MyReader = MyCommand.ExecuteReader();


            //check if the members exist
            string query2 = "SELECT * FROM userdata WHERE userdata.IDMember =" + IDMember + "";
            MySqlCommand MyCommand2 = new MySqlCommand(query2, MyConn);
            MySqlDataReader MyReader2;
            query2 = null;
            MyReader2 = MyCommand2.ExecuteReader();

            if (MyReader2.HasRows)
            {
                MyReader2.Close();
                MyReader = MyCommand.ExecuteReader();
            }
            else
            {
                MessageBox.Show("This Card ID doesn't exist \n Please enter a valid card ID.");
                
            }

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

        public String getAllBooks()
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDBook, BookName FROM books WHERE Availability = 'Yes'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            books = null;

            if (MyReader.HasRows)
            {
                while (MyReader.Read())
                {
                    books += (MyReader["IDBook"].ToString() + " " + MyReader["BookName"].ToString() + "-");
                }
                
            }
            else
            {
                MessageBox.Show("No books are available at the moment.  \n You can reserve.");
                books = "No books are available.";
            }
            return books;
        }

        public String getAllCDs()
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDCD, CDName FROM cd WHERE Availability = 'Yes'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            cds = null;
            if (MyReader.HasRows)
            {
                while (MyReader.Read())
                {
                    cds += (MyReader["IDCD"].ToString() + " " + MyReader["CDName"].ToString() + "-");
                }

            }
            else
            {
                MessageBox.Show("No cds are available at the moment.  \n You can reserve.");
                cds = "No cds are available.";
            }
            return cds;
        }

        public String getAllVidTapes()
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query1 = "SELECT IDTape, TapeName FROM videotape WHERE Availability = 'Yes'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();

            vidtapes = null;
            if (MyReader.HasRows)
            {
                while (MyReader.Read())
                {
                    vidtapes += (MyReader["IDTape"].ToString() + " " + MyReader["TapeName"].ToString() + "-");
                }

            }
            else
            {
                MessageBox.Show("No video tapes are available at the moment.  \n You can reserve.");
                vidtapes = "No tapes are available.";
            }
            return vidtapes;
        }
    }
}
