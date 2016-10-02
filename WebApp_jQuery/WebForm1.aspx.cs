using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 

namespace WebApp_jQuery
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
           
            display.Text = "You have Selected Following Countries: ";
            string str = list2.Items.ToString();
            foreach (ListItem item in list2.Items)
            {
                if (item.Selected)
                {
                    display.Text += "<li><b>" + item.Text + "<b></li>";
                }
            }  
        }

    }
}