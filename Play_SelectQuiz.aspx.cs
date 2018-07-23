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

public partial class Play_SelectQuiz : System.Web.UI.Page
{
    public int iCategoryId = 0;
    public int iQuizId = 0;
    int i = 0;
    string strQuizTitle = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        iCategoryId = Convert.ToInt32(Request.QueryString["ID"].ToString());

        if(!IsPostBack)
        {
          
            DataTable objDT = dbGetIDs.SelectQuizByCategory(iCategoryId);
            if(objDT.Rows.Count > 0)
            {
                for(i=0;i<objDT.Rows.Count;i++)
                {
                    lbPlay_SelectQuiz.Items.Add(objDT.Rows[i]["Title"].ToString());
                }
            }
        }
    }

    protected void lbPlay_SelectQuiz_SelectedIndexChanged(object sender, EventArgs e)
    {
        strQuizTitle = lbPlay_SelectQuiz.SelectedItem.ToString();
        iQuizId = dbGetIDs.GetQuizId(strQuizTitle);
    }

    protected void btnSelectQuiz_Click(object sender, EventArgs e)
    {
        Response.Redirect("Play_SelectQuestion.aspx?ID=" + iQuizId);
    }
}