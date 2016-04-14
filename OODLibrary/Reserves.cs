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

        public Reserves()
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

        public String getReservedItems(string input)//can be changed to type or something
        {
            //setting up initials
            currentlistofid.Clear();
            string itemstring = "";
            string query1 = "";
            MySqlDataReader MyReader;

            MyConn = new MySqlConnection(connection);

            switch (input)
            {
                case "books":
                    query1 = "SELECT IDBook, BookName FROM books WHERE Availability = 'No'";
                    break;

                case "tapes":
                    query1 = "SELECT IDTape, TapeName FROM videotape WHERE Availability = 'No'";
                    break;

                case "cds":
                    query1 = "SELECT IDCD, CDName FROM cd WHERE Availability = 'No'";
                    break;
            }

            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);

            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            //  books = null;
            switch (input)
            {
                case "books":
                    if (MyReader.HasRows)
                    {
                        while (MyReader.Read())
                        {
                            currentlistofid.Add(MyReader["IDBook"].ToString());
                            itemstring += (MyReader["IDBook"].ToString() + " " + MyReader["BookName"].ToString() + "-");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No books are borrowed at the moment.");
                        itemstring = "No books are borrowed at the moment.";
                    }
                    break;

                case "tapes":
                    if (MyReader.HasRows)
                    {
                        while (MyReader.Read())
                        {
                            currentlistofid.Add(MyReader["IDTape"].ToString());
                            itemstring += (MyReader["IDTape"].ToString() + " " + MyReader["TapeName"].ToString() + "-");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No video tapes are borrowed at the moment..");
                        itemstring = "No video tapes are borrowed at the moment.";
                    }
                    break;

                case "cds":
                    if (MyReader.HasRows)
                    {
                        while (MyReader.Read())
                        {
                            currentlistofid.Add(MyReader["IDCD"].ToString());
                            itemstring += (MyReader["IDCD"].ToString() + " " + MyReader["CDName"].ToString() + "-");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No cds are borrowed at the moment.");
                        itemstring = "No cds are borrowed at the moment.";
                    }
                    break;
            }

            return itemstring;
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
            string query = "SELECT * FROM reservations WHERE item_id=" + currentlistofid[id] + " AND type = '" + type + "'";
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
        public void placeReservation(int id, int c_id, string type)
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query = "INSERT INTO reservations VALUES (null," + c_id + "," + "0.5 ," + currentlistofid[id] + "," + "'" + type + "'" + ",CURRENT_TIMESTAMP)";
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }
    }
}