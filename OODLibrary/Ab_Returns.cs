using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OODLibrary
{
    abstract class Ab_Returns
    {
        private static string connection = "datasource=localhost;database=oodlibrary;port=;username=root;password=";
        private  MySqlConnection MyConn;
        private string items;

        public Ab_Returns()
        {
            
        }

        abstract public void showItemBorrowed();

        abstract public void returnItem();

        abstract public void setItemAvailable(int itemId);

    }
}
