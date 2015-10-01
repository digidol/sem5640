using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InitialWebFormExamples
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This version represents the code that would be appropriate for the 
        /// first part of the task to setup a basic Hello World. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SayHelloButton_Version1_Click(object sender, EventArgs e)
        {

            HelloLabel.Text = "Hello, " + NameTextBox.Text;
            //NOTE: the following line does the same thing
            //HelloLabel.Text = String.Format("Hello, {0}", NameTextBox.Text);
            HelloLabel.Visible = true;   
        }

        protected void SayHelloButton_Version2_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text.Trim().ToLower() == "world")
            {
                WorldImage.Visible = true;
                HelloLabel.Visible = false;
                IsbnLink.Visible = false; 
            }
            else
            {
                WorldImage.Visible = false;
                HelloLabel.Visible = true;
                IsbnLink.Visible = true;
                IsbnLink.NavigateUrl = "~/SecondPage.aspx?id=" + HttpUtility.UrlEncode(NameTextBox.Text);
                HelloLabel.Text = String.Format("Hello, {0}", HttpUtility.HtmlEncode(NameTextBox.Text));
            }
        }


    }
}