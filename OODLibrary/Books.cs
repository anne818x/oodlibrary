using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OODLibrary
{
    class Books : Ab_Returns
    {


        public Books()
        {
            
        }

        public override void showItemBorrowed()
        {
            MySqlConnection MyConn = new MySqlConnection(connection);
            string query = "SELECT Items.ID, Items.Itemname, Items.Itemtype, Items.Type, borrow.IDItem, borrow.StartDate FROM books INNER JOIN borrow ON books.IDBook = borrow.IDBook";
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            items = null;
            while (MyReader.Read())
            {
                borrowedBooks += (MyReader["IDBook"].ToString() + "-" + MyReader["BookName"].ToString() + "-" + MyReader["Type"].ToString() + "-" + MyReader["StartDate"].ToString() + "/");
            }
            return borrowedBooks;
            throw new NotImplementedException();
        }

        public override void returnItem()
        {
            throw new NotImplementedException();
        }

        public override void setItemAvailable(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
