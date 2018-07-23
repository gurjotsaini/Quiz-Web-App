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

namespace Quiz
{
    public class dbGetIDs
    {
        public dbGetIDs()
        {
            
        }

        public static int GetCategoryId(string strTitle)
        {
            int iReturnValue = 0;
            DataAccess objDA = new DataAccess("spGetCategoryId");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@title", strTitle);
                iReturnValue = Convert.ToInt32(objDA.mSqlComm.ExecuteScalar());
                return iReturnValue;
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

        public static int GetQuizId(string strTitle)
        {
            int iReturnValue = 0;
            DataAccess objDA = new DataAccess("spGetQuizId");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@title", strTitle);
                iReturnValue = Convert.ToInt32(objDA.mSqlComm.ExecuteScalar());
                return iReturnValue;
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

        public static DataTable SelectQuizByCategory(int iCategoryId)
        {
            DataAccess objDA = new DataAccess("spSelectCategoryIdForQuiz");
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

        public static DataTable ShowQuestion(int iQuizId)
        {
            DataAccess objDA = new DataAccess("spSelectQuizIdForQuestion");
            DataTable objDT = new DataTable();
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizId", iQuizId);
                objDA.mSqlComm.ExecuteNonQuery();

                SqlDataAdapter objSDA = new SqlDataAdapter();
                objSDA.SelectCommand = objDA.mSqlComm;

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

        public static int GetQuestionId(string strQuestionTitle)
        {
            int iReturnValue = 0;
            DataAccess objDA = new DataAccess("spGetQuestionId");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quesTitle", strQuestionTitle);
                iReturnValue = Convert.ToInt32(objDA.mSqlComm.ExecuteScalar());
                return iReturnValue;
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

        public static DataTable ShowOptions(int iQuizQuesId)
        {
            DataAccess objDA = new DataAccess("spSelectQuizQuesIdForOptions");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizQuesId", iQuizQuesId);
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
    }
}