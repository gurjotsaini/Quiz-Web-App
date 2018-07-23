using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Quiz;

public partial class QuizQuestions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Session Begins
        lblUserName.Text = Session["Login"].ToString();
        lblQuizTitle.Text = Session["QuizTitle"].ToString();
        lblCategoryTitle.Text = Session["CategoryId"].ToString();
        // Session Ends

        DataTable objDT = dbQuizQuestions.ShowQuizQuestions();
        repeater_QuizQuestions.DataSource = objDT;
        repeater_QuizQuestions.DataBind();
    }
    protected void repeater_QuizQuestions_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        HiddenField HidddenField_QuizQuestions_Id = (HiddenField)e.Item.FindControl("hfQuizQuestionsID");
        HidddenField_QuizQuestions_Id.Value = ((DataRowView)e.Item.DataItem)["QuizQuestionId"].ToString();

        HyperLink HyperLink_QuizQuestionTitle = (HyperLink)e.Item.FindControl("hlQuizQuestionsTitle");
        HyperLink_QuizQuestionTitle.Text = ((DataRowView)e.Item.DataItem)["QuesTitle"].ToString();
        HyperLink_QuizQuestionTitle.NavigateUrl = "QuizQuestionOptions.aspx?QuizQuestionTitleID=" + HidddenField_QuizQuestions_Id.Value;

        HyperLink HyperLink_Update = (HyperLink)e.Item.FindControl("QuizQuestions_Update");
        HyperLink_Update.NavigateUrl = "QuizQuestionsUpdate.aspx?QuizUpdateID=" + HidddenField_QuizQuestions_Id.Value;

        HyperLink HyperLink_Delete = (HyperLink)e.Item.FindControl("QuizQuestions_Delete");
        HyperLink_Delete.NavigateUrl = "QuizQuestionsDelete.aspx?QuizDeleteID=" + HidddenField_QuizQuestions_Id.Value;

        Label lblQuizId = (Label)e.Item.FindControl("lblQuizId");
        lblQuizId.Text = ((DataRowView)e.Item.DataItem)["QuizId"].ToString();

        Label lblNoOfOptions = (Label)e.Item.FindControl("lblNoOfOptions");
        lblNoOfOptions.Text = ((DataRowView)e.Item.DataItem)["NoOfOptions"].ToString();

        Label lblCorrectOption = (Label)e.Item.FindControl("lblCorrectOption");
        lblCorrectOption.Text = ((DataRowView)e.Item.DataItem)["CorrectOption"].ToString();
    }
}