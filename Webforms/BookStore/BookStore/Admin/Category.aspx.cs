using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStore.Admin
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            if(e.Exception != null)
            {
                System.Diagnostics.Debug.WriteLine("Need to handle the error.");
                e.ExceptionHandled = true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("That was fine"); 
            }
        }
    }
}