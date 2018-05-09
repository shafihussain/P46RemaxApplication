using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCSWinRemaxApplication.DataSource
{
    public static class dataClass
    {
        public static OleDbConnection myConn;
        public static OleDbDataReader myReader;
        public static OleDbDataAdapter myAdapter;
    }
}
