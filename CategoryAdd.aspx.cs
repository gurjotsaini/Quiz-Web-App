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

public partial class CategoryAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnCategorySubmit_Click(object sender, EventArgs e)
    {
        dbCategories.AddCategory(tbTitle.Text, tbDescription.Text, Convert.ToInt32(tbAddedBy.Text), Convert.ToInt32(tbApproved.Text), Convert.ToInt32(tbActive.Text));

        tbTitle.Text = "";
        tbDescription.Text = "";
        tbAddedBy.Text = "";
        tbApproved.Text = "";
        tbActive.Text = "";
    }
}