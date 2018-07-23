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
    public class dbQuizes
    {
        public dbQuizes()
        {

        }

        public static DataTable ShowQuizes()
        {
            DataAccess objDA = new DataAccess("spQuizShow");
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

        public static void AddQuiz(int iCategoryId, string strTitle, string strQuizDesc, int iIsTimeBased, int iNoOfQuestions, int iIsPublished, int iActive)
        {
            DataAccess objDA = new DataAccess("spQuizAdd");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@categoryId",iCategoryId);
                objDA.mSqlComm.Parameters.AddWithValue("@title",strTitle);
                objDA.mSqlComm.Parameters.AddWithValue("@quizDesc",strQuizDesc);
                objDA.mSqlComm.Parameters.AddWithValue("@isTimeBased",iIsTimeBased);
                objDA.mSqlComm.Parameters.AddWithValue("@noOfQuestions",iNoOfQuestions);
                objDA.mSqlComm.Parameters.AddWithValue("@isPublished",iIsPublished);
                objDA.mSqlComm.Parameters.AddWithValue("@active", iActive);
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

        public static DataTable SelectQuiz(int iQuizId)
        {
            DataAccess objDA = new DataAccess("spQuizSelect");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizId", iQuizId);
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

        public static void QuizUpdate(int iQuizId, int iCategoryId, string strTitle, string strQuizDesc, int iIsTimeBased, int iNoOfQuestions, int iIsPublished, int iActive)
        {
            DataAccess objDA = new DataAccess("spQuizUpdate");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizId", iQuizId);
                objDA.mSqlComm.Parameters.AddWithValue("@categoryId", iCategoryId);
                objDA.mSqlComm.Parameters.AddWithValue("@title", strTitle);
                objDA.mSqlComm.Parameters.AddWithValue("@quizDesc", strQuizDesc);
                objDA.mSqlComm.Parameters.AddWithValue("@isTimeBased", iIsTimeBased);
                objDA.mSqlComm.Parameters.AddWithValue("@noOfQuestions", iNoOfQuestions);
                objDA.mSqlComm.Parameters.AddWithValue("@isPublished", iIsPublished);
                objDA.mSqlComm.Parameters.AddWithValue("@active", iActive);
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

        public static void QuizDelete(int iQuizId)
        {
            DataAccess objDA = new DataAccess("spQuizDelete");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizId", iQuizId);
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