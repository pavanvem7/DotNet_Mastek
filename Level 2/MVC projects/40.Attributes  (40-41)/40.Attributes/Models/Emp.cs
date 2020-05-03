using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace _40.Attributes.Models
{
    [MetadataType(typeof(EmployeeMetaData))]
    [DisplayColumn("FullName")]
    public partial class Employee
    {
    }

    public class EmployeeMetaData
    {
        //If you want "FullName" to be displayed as "Full Name", 
        //[DisplayAttribute(Name="Full Name")]
        //[Display(Name = "Full Name")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        


        //To get only the date part in a datetime data type
        //[DisplayFormat(DataFormatString = "{0:d}")]
        //[DisplayFormatAttribute(DataFormatString="{0:d}")]

        //To get time in 24 hour notation
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]

        //To get time in 12 hour notation with AM PM
        // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}")]   //For video 40

        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }


        // If gender is NULL, "Gender not specified" text will be displayed.
        [DisplayFormat(NullDisplayText = "Gender not specified")]
        public string Gender { get; set; }

        //If you don't want to display a column use ScaffoldColumn attribute.
        //This only works when you use @Html.DisplayForModel() helper
        //[ScaffoldColumn(false)]                                                        //for video 40

        [DataType(DataType.Currency)]
        public int? Salary { get; set; }




        //Video 41


        // Generate a hyperlink
        /*[DataType(DataType.Url)]
        public string PersonalWebSite { get; set; }

        // Display mailto hyperlink
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }*/
    }
}