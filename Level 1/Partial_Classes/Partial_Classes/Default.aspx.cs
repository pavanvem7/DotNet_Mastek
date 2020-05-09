using System;
using System.Web;
using System.Web.UI;

namespace Partial_Classes
{

    public partial class Default : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs args)
        {
            Customer c1 = new Customer();
            c1.FirstName = "Pavan";
            c1.LastName = "Vemula";

            string FullName1 = c1.GetFullName();
            Response.Write("Full Name = " + FullName1 + "<br/>");

            PartialCustomer c2 = new PartialCustomer();
            c2.FirstName = "Parth";
            c2.LastName = "Waghmare";

            string FullName2 = c2.GetFullName();
            Response.Write("Full Name = " + FullName2 + "<br/>");
        }
    }
}
