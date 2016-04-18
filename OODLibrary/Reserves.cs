using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace OODLibrary
{
    internal class Reserves
    {
        private string connection = "datasource=localhost;database=oodlibrary;port=;username=root;password=";
        private MySqlConnection MyConn;
        private string reservations;
        private ArrayList currentlistofid;
        private ArrayList currentlisttypes;  //associative arraylist for currentlistofid

        public Reserves()
        {
            currentlistofid = new ArrayList();
            currentlisttypes = new ArrayList();
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

        public String getReservedItems(string input)
        {
            //setting up initials
            currentlistofid.Clear();
            currentlisttypes.Clear();
            string itemstring = "";
            string query1 = "";
            MySqlDataReader MyReader;

            MyConn = new MySqlConnection(connection);

            switch (input)
            {
                case "items":
                    query1 = "SELECT IDItem, ItemName, ItemType FROM items WHERE Availability = 'No'";
                    break;

            }

            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);

            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            //  books = null;
            switch (input)
            {
                case "items":
                    if (MyReader.HasRows)
                    {
                        while (MyReader.Read())
                        {
                            currentlistofid.Add(MyReader["IDItem"].ToString());
                            currentlisttypes.Add(MyReader["ItemType"].ToString());
                            itemstring += (MyReader["IDItem"].ToString() + " " + MyReader["ItemName"].ToString() + " (" + MyReader["ItemType"].ToString() + ")" + "-");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No books are borrowed at the moment.");
                        itemstring = "No books are borrowed at the moment.";
                    }
                    break;

           
            }

            return itemstring;
        }

        public ArrayList giveCurrentSelectionids()
        {
            return this.currentlistofid;
        }

        public ArrayList giveCurrentSelectiontypes()
        {
            return this.currentlisttypes;
        }


        /// <summary>
        /// gets selected index and compares it to  list here to figure out specfic list to generate
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public string getReservations(int id)
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query = "SELECT * FROM reservations WHERE item_id=" + currentlistofid[id] + " AND type = '" +this.currentlisttypes[id]+"'" ;
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            reservations = "";
            while (MyReader.Read())
            {
                reservations += (" ID:" + MyReader["reserv_id"].ToString() + " - Member: " + MyReader["c_ID"].ToString() + " - Type: " + MyReader["Type"].ToString() + " - ItemID:  " + MyReader["item_id"].ToString() + " - Reserve Date:  " + MyReader["reservedate"].ToString() + "?");
            }
            return reservations;
        }

        /// <summary>
        /// places a reservation along with an ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="c_id"></param>
        /// <param name="type"></param>
        public void placeReservation(int id, int c_id)
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query = "INSERT INTO reservations VALUES (null," + c_id + "," + "0.5 ," + currentlistofid[id] + "," + "'" + currentlisttypes[id] + "'" + ",CURRENT_TIMESTAMP)";
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }
    }
}