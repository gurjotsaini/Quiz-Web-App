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
    public class dbQuizQuestionOptions
    {
        public dbQuizQuestionOptions()
        {
            
        }

        public static DataTable ShowQuizQuestionOptions()
        {
            DataAccess objDA = new DataAccess("spQuizQuestionOptionsShow");
            DataTable objDT = new DataTable();
            try
            {
                SqlDataAdapter objSDA = new SqlDataAdapter();
                objSDA.SelectCommand = objDA.mSqlComm;
                objSDA.Fill(objDT);
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

        public static void AddQuizQuestionOptions(int iQuizQuesId, string strTitle)
        {
            DataAccess objDA = new DataAccess("spQuizQuestionoptionsAdd");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizQuesId", iQuizQuesId);
                objDA.mSqlComm.Parameters.AddWithValue("@title", strTitle);
                objDA.mSqlComm.ExecuteNonQuery();
            }
            catch (Exception e)
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

        public static DataTable SelectQuizQuestionOptions(int iQuizQuestionOptionId)
        {
            DataAccess objDA = new DataAccess("spQuizQuestionOptionsSelect");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizQuestionOptionId", iQuizQuestionOptionId);
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

        public static void QuizQuestionOptionsUpdate(int iQuizQuestionOptionId, int iQuizQuesId, string strTitle)
        {
            DataAccess objDA = new DataAccess("spQuizQuestionoptionsUpdate");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizQuestionOptionId", iQuizQuestionOptionId);
                objDA.mSqlComm.Parameters.AddWithValue("@quizQuesId", iQuizQuesId);
                objDA.mSqlComm.Parameters.AddWithValue("@title", strTitle);
                objDA.mSqlComm.ExecuteNonQuery();
            }
            catch (Exception e)
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

        public static void QuizQuestionOptionsDelete(int iQuizQuestionOptionId)
        {
            DataAccess objDA = new DataAccess("spQuizQuestionOptionsDelete");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizQuestionOptionId", iQuizQuestionOptionId);
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