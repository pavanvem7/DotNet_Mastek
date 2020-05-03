using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _37.RadioButton.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string SelectedDepartment { get; set; }
        public List<Department> Departments
        {
            get
            {
                SampleDBContext db = new SampleDBContext();
                return db.Departments.ToList();
            }
        }
    }
}