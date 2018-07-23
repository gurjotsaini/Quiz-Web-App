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

public partial class QuizQuestionsAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnQuizQuestionSubmit_Click(object sender, EventArgs e)
    {
        dbQuizQuestions.AddQuizQuestions(Convert.ToInt32(tbQuizId.Text), tbQuesTitle.Text, Convert.ToInt32(tbNoOfOptions.Text), tbCorrectOption.Text);

        tbQuizId.Text = "";
        tbQuesTitle.Text = "";
        tbNoOfOptions.Text = "";
        tbCorrectOption.Text = "";
    }
}