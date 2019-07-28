using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LinqToSQL.Models
{
    public class DaysModel
    {
        [Required]
        [Display(Name = "Days")]
        public int numOfDaysToEnd { get; set; }
    }
}