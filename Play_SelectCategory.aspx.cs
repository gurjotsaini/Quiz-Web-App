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


public partial class Play_SelectCategory : System.Web.UI.Page
{
    public string strCategoryTitle = "";
    public int iCategoryId = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable objDT = dbCategories.ShowCategories();
            if (objDT.Rows.Count > 0)
            {
                for (int i = 0; i < objDT.Rows.Count; i++)
                {
                    lbPlay_SelectCategory.Items.Add(objDT.Rows[i]["Title"].ToString());
                }
            }
        }
    }

    public void lbPlay_SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        strCategoryTitle = lbPlay_SelectCategory.SelectedItem.ToString();
        iCategoryId = dbGetIDs.GetCategoryId(strCategoryTitle);
    }

    protected void btnSelectCategory_Click(object sender, EventArgs e)
    {
        Response.Redirect("Play_SelectQuiz.aspx?ID=" + iCategoryId);
    }
}