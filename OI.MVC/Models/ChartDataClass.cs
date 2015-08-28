using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OI.MVC.Models
{
  
        public class ChartDataClass
        {
            public DateTime ExecutionDate { get; set; }
            public double ExecutionValue { get; set; }
        }
  
}