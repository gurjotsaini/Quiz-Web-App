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

public partial class QuizQuestionOptions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Session Begins
        lblUserName.Text = Session["Login"].ToString();
        lblQuizTitle.Text = Session["QuizTitle"].ToString();
        lblCategoryTitle.Text = Session["CategoryId"].ToString();
        // Session Ends

        DataTable objDT = dbQuizQuestionOptions.ShowQuizQuestionOptions();
        repeater_QuizQuestionOptionss.DataSource = objDT;
        repeater_QuizQuestionOptionss.DataBind();
    }

    protected void repeater_QuizQuestionOptionss_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        HiddenField HidddenField_QuizQuestionOptions_Id = (HiddenField)e.Item.FindControl("hfQuizQuestionOptionsID");
        HidddenField_QuizQuestionOptions_Id.Value = ((DataRowView)e.Item.DataItem)["QuizQuestionOptionId"].ToString();

        HyperLink HyperLink_Update = (HyperLink)e.Item.FindControl("QuizQuestionOptions_Update");
        HyperLink_Update.NavigateUrl = "QuizQuestionOptionsUpdate.aspx?QuizQuestionOptionUpdateID=" + HidddenField_QuizQuestionOptions_Id.Value;

        HyperLink HyperLink_Delete = (HyperLink)e.Item.FindControl("QuizQuestionOptions_Delete");
        HyperLink_Delete.NavigateUrl = "QuizQuestionOptionsDelete.aspx?QuizQuestionOptionDeleteID=" + HidddenField_QuizQuestionOptions_Id.Value;

        Label lblQuizQuestionId = (Label)e.Item.FindControl("lblQuizQuestionId");
        lblQuizQuestionId.Text = ((DataRowView)e.Item.DataItem)["QuizQuesId"].ToString();

        Label lblTitle = (Label)e.Item.FindControl("lblTitle");
        lblTitle.Text = ((DataRowView)e.Item.DataItem)["Title"].ToString();
    }
}