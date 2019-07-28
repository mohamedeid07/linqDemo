using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqToSQL.Models
{
    public class ProjectModel
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int NumberOfForms { get; set; }
    }
}