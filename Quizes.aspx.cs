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

public partial class Quizes : System.Web.UI.Page
{
    int iCategoryId = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        lblUserName.Text = Session["Login"].ToString(); // Session
        lblCategoryTitle.Text = Session["CategoryId"].ToString();
        //iCategoryId = Convert.ToInt32(Request.QueryString["CategoryTitleID"].ToString());

        
        DataTable objDT = dbQuizes.ShowQuizes();
        //DataTable objDT = dbQuizes.SelectQuiz(iCategoryId);
        repeater_Quizes.DataSource = objDT;
        repeater_Quizes.DataBind();
    }

    protected void repeater_Quizes_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        HiddenField HidddenField_Quiz_Id = (HiddenField)e.Item.FindControl("hfQuizID");
        HidddenField_Quiz_Id.Value = ((DataRowView)e.Item.DataItem)["QuizId"].ToString();

        HyperLink HyperLink_Title = (HyperLink)e.Item.FindControl("hlQuizTitle");
        HyperLink_Title.Text = ((DataRowView)e.Item.DataItem)["Title"].ToString();
        HyperLink_Title.NavigateUrl = "QuizQuestions.aspx?QuizTitleID=" + HidddenField_Quiz_Id.Value;

        HyperLink HyperLink_Update = (HyperLink)e.Item.FindControl("Quiz_Update");
        HyperLink_Update.NavigateUrl = "QuizUpdate.aspx?QuizUpdateID=" + HidddenField_Quiz_Id.Value;

        HyperLink HyperLink_Delete = (HyperLink)e.Item.FindControl("Quiz_Delete");
        HyperLink_Delete.NavigateUrl = "QuizDelete.aspx?QuizDeleteID=" + HidddenField_Quiz_Id.Value;

        Label lblCategoryId = (Label)e.Item.FindControl("lblCategoryId");
        lblCategoryId.Text = ((DataRowView)e.Item.DataItem)["CategoryId"].ToString();

        Label lblQuizDesc = (Label)e.Item.FindControl("lblQuizDesc");
        lblQuizDesc.Text = ((DataRowView)e.Item.DataItem)["QuizDesc"].ToString();

        Label lblIsTimeBased = (Label)e.Item.FindControl("lblIsTimeBased");
        lblIsTimeBased.Text = ((DataRowView)e.Item.DataItem)["IsTimeBased"].ToString();

        Label lblNoOfQuestions = (Label)e.Item.FindControl("lblNoOfQuestions");
        lblNoOfQuestions.Text = ((DataRowView)e.Item.DataItem)["NoOfQuestins"].ToString();

        Label lblIsPublished = (Label)e.Item.FindControl("lblIsPublished");
        lblIsPublished.Text = ((DataRowView)e.Item.DataItem)["IsPublished"].ToString();

        Label lblActive = (Label)e.Item.FindControl("lblActive");
        lblActive.Text = ((DataRowView)e.Item.DataItem)["Active"].ToString();

        Session["QuizesId"] = HidddenField_Quiz_Id.Value;
        Session["QuizTitle"] = HyperLink_Title.Text;
        
    }
}