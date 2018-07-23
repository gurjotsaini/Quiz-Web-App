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
/// Summary description for dbCategories
/// </summary>
namespace Quiz
{
    public class dbCategories
    {
        public dbCategories()
        {
            
        }

        public static DataTable ShowCategories()
        {
            DataAccess objDA = new DataAccess("spCategoryShow");
            DataTable objDT = new DataTable();
            try
            {
                SqlDataAdapter objSDA = new SqlDataAdapter();
                objSDA.SelectCommand = objDA.mSqlComm;
                objSDA.Fill(objDT);
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
            return objDT;
        }

        public static void AddCategory(string strTitle, string strDescription, int iAddedBy, int iApproved, int iActive)
        {
            DataAccess objDA = new DataAccess("spCategoryAdd");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@title",strTitle);
                objDA.mSqlComm.Parameters.AddWithValue("@description",strDescription);
                objDA.mSqlComm.Parameters.AddWithValue("@addedBy",iAddedBy);
                objDA.mSqlComm.Parameters.AddWithValue("@approved",iApproved);
                objDA.mSqlComm.Parameters.AddWithValue("@active", iActive);
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

        public static DataTable SelectCategory(int iCategoryId)
        {
            DataAccess objDA = new DataAccess("spCategorySelect");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@categoryId", iCategoryId);
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

        public static void CategoryUpdate(int iCategoryId, string strTitle, string strDescription, int iAddedBy, int iApproved, int iActive)
        {
            DataAccess objDA = new DataAccess("spCategoryUpdate");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@categoryId", iCategoryId);
                objDA.mSqlComm.Parameters.AddWithValue("@title", strTitle);
                objDA.mSqlComm.Parameters.AddWithValue("@description", strDescription);
                objDA.mSqlComm.Parameters.AddWithValue("@addedBy", iAddedBy);
                objDA.mSqlComm.Parameters.AddWithValue("@approved", iApproved);
                objDA.mSqlComm.Parameters.AddWithValue("@active", iActive);
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

        public static void CategoryDelete(int iCategoryId)
        {
            DataAccess objDA = new DataAccess("spCategoryDelete");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@categoryId", iCategoryId);
                objDA.mSqlComm.ExecuteNonQuery();
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
    }
}