using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Quiz
{
    public class DataAccess
    {
        public DataAccess()
        { 
        
        }
		
        public SqlCommand mSqlComm;
        public SqlConnection mSqlConn;

        public DataAccess(string str)
        {
            try
            {
                if (mSqlConn == null)
                    mSqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

                if (mSqlConn.State == ConnectionState.Closed)
                    mSqlConn.Open();

                mSqlComm = new SqlCommand();
                mSqlComm.Connection = mSqlConn;
                mSqlComm.CommandType = CommandType.StoredProcedure;
                mSqlComm.CommandText = str;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void CloseConnection()
        {
            if (mSqlConn.State == ConnectionState.Open)
                mSqlConn.Close();
        }

        public void DisposeConnection()
        {
            if (mSqlConn != null)
            {
                mSqlConn.Dispose();
                mSqlConn = null;
            }
        }
        
    }
}
