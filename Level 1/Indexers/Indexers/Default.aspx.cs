using System;
using System.Web;
using System.Web.UI;

namespace Indexers
{

    public partial class Default : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs args)
        {
            Company company = new Company();
            Response.Write("Name of Employee with Id = 2: " + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id = 5: " + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id = 8: " + company[8]);

            Response.Write("<br/>");
            Response.Write("<br/>");

            Response.Write("Changing names of employees with Id = 2,5,8");
            Response.Write("<br/>");
            company[2] = "Pavan";
            company[5] = "Suyog";
            company[8] = "Innani";

            Response.Write("Name of Employee with Id = 2: " + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id = 5: " + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id = 8: " + company[8]);

            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("<br/>");


            Response.Write("Before changing the Gender of all male employees to Female");
            Response.Write("<br/>");

            Response.Write("Total Employees with Gender = Male:" + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Female:" + company["Female"]);
            Response.Write("<br/>");
            Response.Write("<br/>");

            company["Male"] = "Female";

            Response.Write("After changing the Gender of all male employees to Female");
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Male:" + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Female:" + company["Female"]);
        }
    }
}
