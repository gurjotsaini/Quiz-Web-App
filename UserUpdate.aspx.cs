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

public partial class UserUpdate : System.Web.UI.Page
{
    int iUserId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        iUserId = Convert.ToInt32(Request.QueryString["UserUpdateID"].ToString());
        if(!IsPostBack)
        {
            DataTable objDT = db.SelectUserForUpdate(iUserId);
            if(objDT.Rows.Count > 0)
            {
                tbEmailId.Text = objDT.Rows[0]["EmailId"].ToString();
                tbFirstName.Text = objDT.Rows[0]["FirstName"].ToString();
                tbLastName.Text = objDT.Rows[0]["LastName"].ToString();
                tbUserRole.Text = objDT.Rows[0]["UserRole"].ToString();
                tbPassword.Text = objDT.Rows[0]["UserPassword"].ToString();
            }
        }
    }
    protected void btnUserSubmit_Click(object sender, EventArgs e)
    {
        db.UserUpdate(iUserId, tbEmailId.Text, tbFirstName.Text, tbLastName.Text, tbUserRole.Text, tbPassword.Text);
        tbEmailId.Text = "";
        tbFirstName.Text = "";
        tbLastName.Text = "";
        tbUserRole.Text = "";
        tbPassword.Text = "";
    }
}