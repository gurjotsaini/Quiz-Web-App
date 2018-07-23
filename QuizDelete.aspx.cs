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

public partial class QuizDelete : System.Web.UI.Page
{
    int iQuizId = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        iQuizId = Convert.ToInt32(Request.QueryString["QuizDeleteID"].ToString());

        if (!IsPostBack)
        {
            DataTable objDT = dbQuizes.SelectQuiz(iQuizId);
            if (objDT.Rows.Count > 0)
            {
                tbCategoryId.Text = objDT.Rows[0]["CategoryId"].ToString();
                tbTitle.Text = objDT.Rows[0]["Title"].ToString();
                tbQuizDesc.Text = objDT.Rows[0]["QuizDesc"].ToString();
                tbIsTimeBased.Text = objDT.Rows[0]["IsTimeBased"].ToString();
                tbNoOfQuestions.Text = objDT.Rows[0]["NoOfQuestins"].ToString();
                tbIsPublished.Text = objDT.Rows[0]["IsPublished"].ToString();
                tbActive.Text = objDT.Rows[0]["Active"].ToString();
            }
        }
    }
    protected void btnDeleteQuizSubmit_Click(object sender, EventArgs e)
    {
        dbQuizes.QuizDelete(iQuizId);

        tbCategoryId.Text = "";
        tbTitle.Text = "";
        tbQuizDesc.Text = "";
        tbIsTimeBased.Text = "";
        tbNoOfQuestions.Text = "";
        tbIsPublished.Text = "";
        tbActive.Text = "";
    }
}