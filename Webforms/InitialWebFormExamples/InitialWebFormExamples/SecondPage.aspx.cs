using System;
using System.Web;

namespace InitialWebFormExamples
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                IsbnLabel.Text = String.Format("The id is: {0}", HttpUtility.HtmlEncode(Request.QueryString["id"]));
            }
            catch
            {
                IsbnLabel.Text = "There was a problem extracting the string.";
            }
        }
    }
}