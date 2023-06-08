using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBrewPOS
{
    internal class DBConnection
    {
        public string myConn()
        {
            string con = @"Data Source=ALJAYVE\SQLEXPRESS;Initial Catalog=BigBrewPOS;Integrated Security=True";
            return con;
        }
    }
}
