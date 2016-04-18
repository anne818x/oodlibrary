using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OODLibrary
{
    class Returns
    {
        private string connection = "datasource=localhost;database=oodlibrary;port=;username=root;password=";
        MySqlConnection MyConn;
        private string borrowedItems;

        //Displaying all items from the borrowed table in the DB
        public String showBorrowedItem()
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query = "SELECT items.IDItem, items.ItemName, itemtypes.ItemType, items.Type, items.ISBN, items.ReleaseDate, borrow.BorrowID, borrow.IDItem, borrow.StartDate FROM items INNER JOIN borrow ON items.IDItem = borrow.IDItem INNER JOIN itemtypes ON items.IDItemType= itemtypes.IDItemType";
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            borrowedItems = "";
            while (MyReader.Read())
            {
                String releaseDate = "";
                if (MyReader["ReleaseDate"].ToString() == "")
                {
                    releaseDate = " ";
                }
                else
                {
                    releaseDate = MyReader["ReleaseDate"].ToString();
                }
                borrowedItems += (MyReader["IDItem"].ToString() + "-" + MyReader["ItemName"].ToString() + "-" + MyReader["ItemType"].ToString() +
                    "-" + MyReader["Type"].ToString() + "-" + MyReader["ISBN"].ToString() + "-" + releaseDate + "-" + MyReader["StartDate"].ToString() + "/");
            }
            return borrowedItems;
        }

        //Returning the selected item and deleting it off the borrow table
        public void returnItem(int itemId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "DELETE FROM borrow WHERE IDItem =" + "'" + itemId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }

        //once returned it changes the availability back to yes
        public void setItemAvailable(int itemId)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "UPDATE items SET Availability = 'Yes' WHERE IDItem = " + "'" + itemId + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }
    }
}