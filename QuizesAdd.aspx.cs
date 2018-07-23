using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Quiz;

public partial class QuizesAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnQuizSubmit_Click(object sender, EventArgs e)
    {
        dbQuizes.AddQuiz(Convert.ToInt32(tbCategoryId.Text), tbTitle.Text, tbQuizDesc.Text, Convert.ToInt32(tbIsTimeBased.Text), Convert.ToInt32(tbNoOfQuestions.Text), Convert.ToInt32(tbIsPublished.Text), Convert.ToInt32(tbActive.Text));

        tbCategoryId.Text = "";
        tbTitle.Text = "";
        tbQuizDesc.Text = "";
        tbIsTimeBased.Text = "";
        tbNoOfQuestions.Text = "";
        tbIsPublished.Text = "";
        tbActive.Text = "";
    }
}