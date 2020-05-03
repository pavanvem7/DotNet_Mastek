using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace _25.Models
{
    public class DepartmentTotal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Total { get; set; }
    }
}