using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Quiz;

public partial class Users : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblUserName.Text = Session["Login"].ToString(); //Session

        DataTable objDT = db.ShowUser();
        repeater_Users.DataSource = objDT;
        repeater_Users.DataBind();
    }
    protected void repeater_Users_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        HiddenField HiddenField_ID = (HiddenField)e.Item.FindControl("User_HiddenID");
        HiddenField_ID.Value = ((DataRowView)e.Item.DataItem)["UserId"].ToString();

        HyperLink HyperLink_Update = (HyperLink)e.Item.FindControl("User_Update");
        HyperLink_Update.NavigateUrl = "UserUpdate.aspx?UserUpdateID=" + HiddenField_ID.Value;

        HyperLink HyperLink_Delete = (HyperLink)e.Item.FindControl("User_Delete");
        HyperLink_Delete.NavigateUrl = "UserDelete.aspx?UserDeleteId=" + HiddenField_ID.Value;

        Label lblEmailId = (Label)e.Item.FindControl("lblEmailId");
        lblEmailId.Text = ((DataRowView)e.Item.DataItem)["EmailId"].ToString();

        Label lblPassword = (Label)e.Item.FindControl("lblUserPassword");
        lblPassword.Text = ((DataRowView)e.Item.DataItem)["UserPassword"].ToString();

        Label lblFirstName = (Label)e.Item.FindControl("lblFirstName");
        lblFirstName.Text = ((DataRowView)e.Item.DataItem)["FirstName"].ToString();

        Label lblLastName = (Label)e.Item.FindControl("lblLastName");
        lblLastName.Text = ((DataRowView)e.Item.DataItem)["LastName"].ToString();

        Label lblUserRole = (Label)e.Item.FindControl("lblUserRole");
        lblUserRole.Text = ((DataRowView)e.Item.DataItem)["UserRole"].ToString();
    }
}