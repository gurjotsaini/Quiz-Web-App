using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using Quiz;

public partial class QuizQuestionsDelete : System.Web.UI.Page
{
    int iQuizQuestionId = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        iQuizQuestionId = Convert.ToInt32(Request.QueryString["QuizDeleteID"].ToString());

        if (!IsPostBack)
        {
            DataTable objDT = dbQuizQuestions.SelectQuizQuestions(iQuizQuestionId);
            if (objDT.Rows.Count > 0)
            {
                tbQuizId.Text = objDT.Rows[0]["QuizId"].ToString();
                tbQuesTitle.Text = objDT.Rows[0]["QuesTitle"].ToString();
                tbNoOfOptions.Text = objDT.Rows[0]["NoOfOptions"].ToString();
                tbCorrectOption.Text = objDT.Rows[0]["CorrectOption"].ToString();
            }
        }
    }
    protected void btnDeleteQuizQuestionSubmit_Click(object sender, EventArgs e)
    {
        dbQuizQuestions.QuizQuestionsDelete(iQuizQuestionId);

        tbQuizId.Text = "";
        tbQuesTitle.Text = "";
        tbNoOfOptions.Text = "";
        tbCorrectOption.Text = "";
    }
}