using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Quiz;
    using System.Data.SqlClient;

/// <summary>
/// Summary description for db
/// </summary>
namespace Quiz
{
    public class db
    {
        public db()
        {

        }

        public static DataTable ShowUser()
        {
            DataAccess objDA = new DataAccess("spShowUsers");
            DataTable objDT = new DataTable();
            try
            {
                SqlDataAdapter objSDA = new SqlDataAdapter();
                objSDA.SelectCommand = objDA.mSqlComm;
                objSDA.Fill(objDT);
                //return objDT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDA.CloseConnection();
                objDA.DisposeConnection();
                objDA = null;
            }
            return objDT;
        }

        public static void AddUser(string strEmailID, string strFirstName, string strLastName, string strUserRole, string strPassworsd)
        {
            DataAccess objDA = new DataAccess("spUserAdd");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@emailId", strEmailID);
                objDA.mSqlComm.Parameters.AddWithValue("@firstName", strFirstName);
                objDA.mSqlComm.Parameters.AddWithValue("@lastName", strLastName);
                objDA.mSqlComm.Parameters.AddWithValue("@userRole", strUserRole);
                objDA.mSqlComm.Parameters.AddWithValue("@userPassword", strPassworsd);
                objDA.mSqlComm.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                objDA.CloseConnection();
                objDA.DisposeConnection();
                objDA = null;
            }
        }

        public static DataTable SelectUserForUpdate(int iUserId)
        {
            DataAccess objDA = new DataAccess("spUserSelectForUpdate");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@userId", iUserId);
                objDA.mSqlComm.ExecuteNonQuery();

                SqlDataAdapter objSDA = new SqlDataAdapter();
                objSDA.SelectCommand = objDA.mSqlComm;
                
                DataTable objDT = new DataTable();
                objSDA.Fill(objDT);
                return objDT;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDA.CloseConnection();
                objDA.DisposeConnection();
                objDA = null;
            }
        }

        public static void UserUpdate(int iUserID, string strEmailId, string strFirstName, string strLastName, string strUserRole, string strUserPassword)
        {
            DataAccess objDA = new DataAccess("spUserUpdate");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@userId", iUserID);
                objDA.mSqlComm.Parameters.AddWithValue("@emailId", strEmailId);
                objDA.mSqlComm.Parameters.AddWithValue("@firstName", strFirstName);
                objDA.mSqlComm.Parameters.AddWithValue("@lastName", strLastName);
                objDA.mSqlComm.Parameters.AddWithValue("@userRole", strUserRole);
                objDA.mSqlComm.Parameters.AddWithValue("@userPassword", strUserPassword);
                objDA.mSqlComm.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDA.CloseConnection();
                objDA.DisposeConnection();
                objDA = null;
            }
        }

        public static DataTable SelectUserForDelete(int iUserId)
        {
            DataAccess objDA = new DataAccess("spUserSelectForUpdate");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@userId", iUserId);
                objDA.mSqlComm.ExecuteNonQuery();

                SqlDataAdapter objSDA = new SqlDataAdapter();
                objSDA.SelectCommand = objDA.mSqlComm;

                DataTable objDT = new DataTable();
                objSDA.Fill(objDT);
                return objDT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDA.CloseConnection();
                objDA.DisposeConnection();
                objDA = null;
            }
        }

        public static void UserDelete(int iUserId)
        {
            DataAccess objDA = new DataAccess("spUserDelete");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@userId", iUserId);
                objDA.mSqlComm.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDA.CloseConnection();
                objDA.DisposeConnection();
                objDA = null;
            }
        }
    }
}