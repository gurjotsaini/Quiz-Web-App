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
    public class dbQuizQuestions
    {
        public dbQuizQuestions()
        {

        }

        public static DataTable ShowQuizQuestions()
        {
            DataAccess objDA = new DataAccess("spQuizQuestionsShow");
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

        public static void AddQuizQuestions(int iQuizId, string strQuesTitle, int iNoOfOptions, string strCorrectOption)
        {
            DataAccess objDA = new DataAccess("spQuizQuestionsAdd");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizId", iQuizId);
                objDA.mSqlComm.Parameters.AddWithValue("@quesTitle", strQuesTitle);
                objDA.mSqlComm.Parameters.AddWithValue("@noOfOptions", iNoOfOptions);
                objDA.mSqlComm.Parameters.AddWithValue("@correctOption", strCorrectOption);
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

        public static DataTable SelectQuizQuestions(int iQuizQuestionId)
        {
            DataAccess objDA = new DataAccess("spQuizQuestionsSelect");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizQuestionId", iQuizQuestionId);
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

        public static void QuizQuestionsUpdate(int iQuizQuestionId, int iQuizId, string strQuesTitle, int iNoOfOptions, string strCorrectOption)
        {
            DataAccess objDA = new DataAccess("spQuizQuestionsUpdate");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizQuestionId", iQuizQuestionId);
                objDA.mSqlComm.Parameters.AddWithValue("@quizId", iQuizId);
                objDA.mSqlComm.Parameters.AddWithValue("@quesTitle", strQuesTitle);
                objDA.mSqlComm.Parameters.AddWithValue("@noOfOptions", iNoOfOptions);
                objDA.mSqlComm.Parameters.AddWithValue("@correctOption", strCorrectOption);
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

        public static void QuizQuestionsDelete(int iQuizQuestionId)
        {
            DataAccess objDA = new DataAccess("spQuizQuestionsDelete");
            try
            {
                objDA.mSqlComm.Parameters.AddWithValue("@quizQuestionId", iQuizQuestionId);
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