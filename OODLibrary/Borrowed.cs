﻿using System;
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
        private string items;


        //Adding a item to the borrowed table 
        public void addBorrow(string IDMember, string IDItem)
        {
            MyConn = new MySqlConnection(connection);

            string query1 = "INSERT INTO borrow (IDMember,IDItem,StartDate) VALUES(" + IDMember + "," + IDItem + "," + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
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

        //changing the availability of the cd tape or book to no in the items table
        public void setItemBorrowedNotAvailable(String IDItem)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "UPDATE items SET Availability = 'No' WHERE IDItem = " + "'" + IDItem + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }
       
        //To get all the items that have the availability of yes, to display the items that can be borrowed
        public String getAllItems()
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "SELECT items.IDItem, items.ItemName, itemtypes.ItemType FROM items, itemtypes WHERE Availability = 'Yes' AND itemtypes.IDItemType = items.IDItemType";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            items = null;

            if (MyReader.HasRows)
            {
                while (MyReader.Read())
                {
                    items += (MyReader["IDItem"].ToString() + " " + MyReader["ItemName"].ToString() + " (" + MyReader["ItemType"].ToString()+")" + "-");
                }
                
            }
            else
            {
                MessageBox.Show("No items are available at the moment.  \n You can reserve.");
                items = "No items are available.";
            }
            return items;
        }
       
    }
}
