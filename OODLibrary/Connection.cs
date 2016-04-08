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
        private string connection = "datasource=localhost;database=oodlibrary;port=;username=root;password=";


        MySqlConnection MyConn;


        private string reservations;
        private ArrayList currentlistofid;

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
            string query1 = "SELECT IDBook, BookName FROM books WHERE Availability = 'Yes'";
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
            string query1 = "SELECT IDCD, CDName FROM cd WHERE Availability = 'Yes'";
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
        string query1 = "SELECT IDTape, TapeName FROM videotape WHERE Availability = 'Yes'";
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

        public void returnTape(int tapeId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "DELETE FROM borrow WHERE IDTape =" + "'" + tapeId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }

        public void setTapeAvailable(int tapeId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "UPDATE videotape SET Availability = 'Yes' WHERE IDTape = " + "'" + tapeId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }




        public ArrayList giveCurrentSelectionids()
        {
            return this.currentlistofid;
        }

        /// <summary>
        /// gets selected index and compares it to  list here to figure out specfic list to generate
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public string getReservations(int id, string type)
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query = "SELECT * FROM reservations WHERE item_id=" + currentlistofid[id] + " AND type = '"+type+"'";
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            reservations = "";
            while (MyReader.Read())
            {
                reservations+= (" ID:"+MyReader["reserv_id"].ToString() + " - Member: " + MyReader["c_ID"].ToString() + " - Type: " + MyReader["Type"].ToString() + " - ItemID:  " + MyReader["item_id"].ToString() + " - Reserve Date:  " + MyReader["reservedate"].ToString()+ "?");
            
            }
            return reservations;
        }


        /// <summary>
        /// places a reservation along with an ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="c_id"></param>
        /// <param name="type"></param>
        public void placeReservation(int id, int c_id,  string type)
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query = "INSERT INTO reservations VALUES (null," + c_id +","+ "0.5 ," + currentlistofid[id] +","+"'" +type + "'"+ ",CURRENT_TIMESTAMP)"; 
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }


    }
}
