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

public partial class Categories : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        lblUserName.Text = Session["Login"].ToString(); // Session

        DataTable objDT = dbCategories.ShowCategories();
        repeater_Categories.DataSource = objDT;
        repeater_Categories.DataBind();
    }
    protected void repeater_Categories_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        HiddenField HiddenField_Cat_Id = (HiddenField)e.Item.FindControl("Category_HiddenID");
        HiddenField_Cat_Id.Value = ((DataRowView)e.Item.DataItem)["CategoryId"].ToString();

        HyperLink HyperLink_Title = (HyperLink)e.Item.FindControl("Category_Title");
        HyperLink_Title.Text = ((DataRowView)e.Item.DataItem)["Title"].ToString();
        HyperLink_Title.NavigateUrl = "Quizes.aspx?CategoryTitleID=" + HiddenField_Cat_Id.Value;

        HyperLink HyperLink_Update = (HyperLink)e.Item.FindControl("Category_Update");
        HyperLink_Update.NavigateUrl = "CategoryUpdate.aspx?CategoryUpdateID=" + HiddenField_Cat_Id.Value;

        HyperLink HyperLink_Delete = (HyperLink)e.Item.FindControl("Category_Delete");
        HyperLink_Delete.NavigateUrl = "CategoryDelete.aspx?CategoryDeleteID=" + HiddenField_Cat_Id.Value;

        Label lblDescription = (Label)e.Item.FindControl("lblDescription");
        lblDescription.Text = ((DataRowView)e.Item.DataItem)["Description"].ToString();

        Label lblAddedBy = (Label)e.Item.FindControl("lblAddedBy");
        lblAddedBy.Text = ((DataRowView)e.Item.DataItem)["AddedBy"].ToString();

        Label lblApproved = (Label)e.Item.FindControl("lblApproved");
        lblApproved.Text = ((DataRowView)e.Item.DataItem)["Approved"].ToString();

        Label lblActive = (Label)e.Item.FindControl("lblActive");
        lblActive.Text = ((DataRowView)e.Item.DataItem)["Active"].ToString();

        Session["CategoryId"] = HyperLink_Title.Text;
    }
}