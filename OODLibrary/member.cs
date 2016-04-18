using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODLibrary
{
    class member
    {
        MySqlConnection MyConn;
        private string members;
        private string connection = "datasource=localhost;database=oodlibrary;port=;username=root;password=";

        //getting all the members from the database 
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

        //Adding member to the userdata table in the database
        public void addMember(string name, string age)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "INSERT INTO userdata (MemberName,Age) VALUES(" + "'" + name + "'" + "," + "'" + age + "'" + ")";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
        }

        //Deleting member from the userdata table
        public void deleteMember(string IDMember)
        {
            MyConn = new MySqlConnection(connection);
            string query1 = "DELETE FROM userdata WHERE IDMember =" + "'" + IDMember + "'";
            MySqlCommand MyCommand = new MySqlCommand(query1, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
           

            //check if the member has already borrowed items
            string query2 = "SELECT userdata.IDMember FROM userdata, borrow WHERE userdata.IDMember = borrow.IDMember AND userdata.IDMember = '" + IDMember + "'";
            MySqlCommand MyCommand2 = new MySqlCommand(query2, MyConn);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();

            if (MyReader2.HasRows)
            {
                MessageBox.Show("This member has items in their possession that still need to be returned. \n You cannot delete this member.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyReader2.Close();
                MyReader = MyCommand.ExecuteReader();
            }

        }

    }
}
