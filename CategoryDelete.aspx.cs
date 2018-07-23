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

public partial class CategoryDelete : System.Web.UI.Page
{
    int iCategoryId = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        iCategoryId = Convert.ToInt32(Request.QueryString["CategoryDeleteID"].ToString());
        if (!IsPostBack)
        {
            DataTable objDT = dbCategories.SelectCategory(iCategoryId);
            if (objDT.Rows.Count > 0)
            {
                tbTitle.Text = objDT.Rows[0]["Title"].ToString();
                tbDescription.Text = objDT.Rows[0]["Description"].ToString();
                tbAddedBy.Text = objDT.Rows[0]["AddedBy"].ToString();
                tbApproved.Text = objDT.Rows[0]["Approved"].ToString();
                tbActive.Text = objDT.Rows[0]["Active"].ToString();
            }
        }
    }
    protected void btnDeleteCategorySubmit_Click(object sender, EventArgs e)
    {
        dbCategories.CategoryDelete(iCategoryId);
        tbTitle.Text = "";
        tbDescription.Text = "";
        tbAddedBy.Text = "";
        tbApproved.Text = "";
        tbActive.Text = "";
    }
}