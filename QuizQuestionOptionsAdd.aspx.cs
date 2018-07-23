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

public partial class QuizQuestionOptionsAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnQuizQuestionOptionSubmit_Click(object sender, EventArgs e)
    {
        dbQuizQuestionOptions.AddQuizQuestionOptions(Convert.ToInt32(tbQuizQuestionId.Text), tbTitle.Text);

        tbQuizQuestionId.Text = "";
        tbTitle.Text = "";
    }
}