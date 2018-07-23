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

public partial class Play_SelectQuestion : System.Web.UI.Page
{
    int i = 0;
    int iCount = 0;
    public string strQuestion = "";
    public int iQuizId = 0;
    public int iQuestionId = 0;
    int iCountRight = 0;
    int iCountWrong = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        iQuizId = Convert.ToInt32(Request.QueryString["ID"].ToString());
        if (!IsPostBack)
        {
            DataTable objDT = dbGetIDs.ShowQuestion(iQuizId);
            iCount = objDT.Rows.Count;
            if (objDT.Rows.Count > 0)
            {
                lblShowQuestion.Text = objDT.Rows[0]["QuesTitle"].ToString();
                
            }
            strQuestion = lblShowQuestion.Text;
            iQuestionId = dbGetIDs.GetQuestionId(strQuestion);
            

            DataTable objDTOptions = dbGetIDs.ShowOptions(iQuestionId);
            cblPlay_SelectQuestion.Items.Add(objDT.Rows[0]["CorrectOption"].ToString());
            for(i=0;i<objDTOptions.Rows.Count;i++)
            {
                cblPlay_SelectQuestion.Items.Add(objDTOptions.Rows[i]["Title"].ToString());
            }
        }
    }
    protected void btnPrevious_Click(object sender, EventArgs e)
    {
        cblPlay_SelectQuestion.Items.Clear();
        DataTable objDT = dbGetIDs.ShowQuestion(iQuizId);
        iCount = objDT.Rows.Count;
        if(i == iCount)
        {
            i--;
            if(i >= 0)
            {
                lblShowQuestion.Text = objDT.Rows[i]["QuesTitle"].ToString();
                i--;
            }
        }
        if (i >= 0)
        {
            lblShowQuestion.Text = objDT.Rows[i]["QuesTitle"].ToString();
            i--;
        }
        strQuestion = lblShowQuestion.Text;
        iQuestionId = dbGetIDs.GetQuestionId(strQuestion);

        DataTable objDTOptions = dbGetIDs.ShowOptions(iQuestionId);
        for(i=1; i<=objDT.Rows.Count; i++)
        {
            if(iQuestionId == i)
            {
                cblPlay_SelectQuestion.Items.Add(objDT.Rows[i - 1]["CorrectOption"].ToString());
            }
        }
        for(i=0; i<objDTOptions.Rows.Count; i++)
        {
            cblPlay_SelectQuestion.Items.Add(objDTOptions.Rows[i]["Title"].ToString());
        }
    }
    protected void btnNext_Click(object sender, EventArgs e)
    {
        cblPlay_SelectQuestion.Items.Clear();
        DataTable objDT = dbGetIDs.ShowQuestion(iQuizId);
        iCount = objDT.Rows.Count;
        if (i < 0)
        {
            i = 0;
            if (i < iCount)
            {
                lblShowQuestion.Text = objDT.Rows[i]["QuesTitle"].ToString();
                i++;
            }
        }
        if (i < iCount)
        {
            lblShowQuestion.Text = objDT.Rows[i]["QuesTitle"].ToString();
            i++;
        }
        strQuestion = lblShowQuestion.Text;
        iQuestionId = dbGetIDs.GetQuestionId(strQuestion);

        DataTable objDTOptions = dbGetIDs.ShowOptions(iQuestionId);
        for (i = 1; i <= objDT.Rows.Count; i++)
        {
            if (iQuestionId == i)
            {
                cblPlay_SelectQuestion.Items.Add(objDT.Rows[i - 1]["CorrectOption"].ToString());
            }
        }
        for (i = 0; i < objDTOptions.Rows.Count; i++)
        {
            cblPlay_SelectQuestion.Items.Add(objDTOptions.Rows[i]["Title"].ToString());
        }
    }

    protected void lbPlay_SelectQuestion_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnSelectQuestion_Click(object sender, EventArgs e)
    {
        string strSelectedOption = cblPlay_SelectQuestion.SelectedItem.ToString();

        DataAccess objDA = new DataAccess("spQuizQuestionsShow");
        DataTable objDT = new DataTable();
        try
        {
            SqlDataAdapter objSDA = new SqlDataAdapter();
            objSDA.SelectCommand = objDA.mSqlComm;
            objSDA.Fill(objDT);
            if (objDT.Rows.Count > 0)
            {
                for (i = 0; i < objDT.Rows.Count; i++)
                {
                    if(objDT.Rows[i]["CorrectOption"] == strSelectedOption)
                    {
                        iCountWrong++;
                    }
                    else
                    {
                        iCountRight++;
                    }
                    Session["CorrectAnswers"] = iCountRight;
                    Session["WrongAnswers"] = iCountWrong;
                    Response.Redirect("Result.aspx?Correct=" + iCountRight);
                }
            }


            


        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void cblPlay_SelectQuestion_SelectedIndexChanged(object sender, EventArgs e)
    {
        //var item = "";
        var item = cblPlay_SelectQuestion.SelectedItem.ToString();

            //foreach(item in cblplay_selectquestion.selecteditem.)
            //{
            //    selected_item = 
            //}
        
        //foreach(CheckBoxList item in cblPlay_SelectQuestion.Items)
        //{
        //    if(item.SelectedItem = true)
        //    {
        //        lblShowQuestion.Items.Add(item);
        //    }
        //}
    }
}