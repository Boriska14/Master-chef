using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace KitchenApp.model
{
    public class Connection
    {
        public SqlConnection conn { get; set; }

        public Connection(String user, String db, String password)
        {

        }
    }
}
