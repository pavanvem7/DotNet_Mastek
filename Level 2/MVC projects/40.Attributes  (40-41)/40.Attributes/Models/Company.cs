using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _40.Attributes.Models
{
    public class Company
    {
        [Key]
        public int ID { get; set; }
        public Employee CompanyDirector
        {
            get
            {
                SampleDBContext db = new SampleDBContext();
                return db.Employees.Single(x => x.Id == 1);
            }
        }
    }
}