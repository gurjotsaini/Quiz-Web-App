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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        DataAccess objDA = new DataAccess("spUserLogin");
        DataTable objDT = new DataTable();
        try
        {
            SqlDataAdapter objSDA = new SqlDataAdapter();
            objSDA.SelectCommand = objDA.mSqlComm;
            objSDA.Fill(objDT);
            if (objDT.Rows.Count > 0)
            {
                for (int i = 0; i < objDT.Rows.Count; i++)
                {
                    if (tbName.Text == objDT.Rows[i]["FirstName"].ToString() && tbPassword.Text == objDT.Rows[i]["UserPassword"].ToString())
                    {
                        Session["Login"] = tbName.Text;
                        Response.Redirect("Main.aspx");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}