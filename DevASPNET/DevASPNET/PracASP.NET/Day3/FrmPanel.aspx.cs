﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevASPNET.Day3
{
    public partial class FrmPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // 텍스트박스에 포커스 두기
                Page.SetFocus(txtMessage);
            }

            // 로드될 때 첫 번째 패널만 보이기
            pnlFirst.Visible = true;
            pnlSecond.Visible = false;
            // 첫 번째 패널 >> 두 번째 패널 보이기
            btnShowPanel1.Visible = false;
            btnShowPanel2.Visible = true;
        }

        protected void btnShowPanel1_Click(object sender, EventArgs e)
        {
            pnlFirst.Visible = true;
            pnlSecond.Visible = false;
            btnShowPanel1.Visible = false;
            btnShowPanel2.Visible = true;
            // 텍스트박스에 포커스
            SetFocus(txtMessage);
            pnlCommand.DefaultButton = "btnShowPanel2";
        }

        protected void btnShowPanel2_Click(object sender, EventArgs e)
        {
            pnlFirst.Visible = false;
            pnlSecond.Visible = true;
            btnShowPanel1.Visible = true;
            btnShowPanel2.Visible = false;
            // 텍스트박스에 포커스
            SetFocus(txtMessage);
            pnlCommand.DefaultButton = "btnShowPanel1";
        }
    }
}