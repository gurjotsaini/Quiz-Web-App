﻿using System;
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

public partial class QuizQuestionOptionsDelete : System.Web.UI.Page
{
    int iQuizQuestionOptionID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        iQuizQuestionOptionID = Convert.ToInt32(Request.QueryString["QuizQuestionOptionDeleteID"].ToString());

        if (!IsPostBack)
        {
            DataTable objDT = dbQuizQuestionOptions.SelectQuizQuestionOptions(iQuizQuestionOptionID);
            if (objDT.Rows.Count > 0)
            {
                tbQuizQuestionId.Text = objDT.Rows[0]["QuizQuesId"].ToString();
                tbTitle.Text = objDT.Rows[0]["Title"].ToString();
            }
        }
    }
    protected void btnDeleteQuizQuestionOptionSubmit_Click(object sender, EventArgs e)
    {
        dbQuizQuestionOptions.QuizQuestionOptionsDelete(iQuizQuestionOptionID);

        tbQuizQuestionId.Text = "";
        tbTitle.Text = "";
    }
}