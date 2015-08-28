using System.ComponentModel.DataAnnotations;
using System;
namespace OI.MVC.Models
{
    public class DocumentViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Filename")]
        public string Filename { get; set; }

        [Display(Name = "SortCenter")]
        public string SortCenter { get; set; }

        [Display(Name = "ReceivedDateFrom")]
        public DateTime ReceivedDateFrom { get; set; }

        [Display(Name = "PreparedBy")]
        public string PreparedBy { get; set; }

        [Display(Name = "UserUploaded")]
        public string UserUploaded { get; set; }


        [Display(Name = "DateUploaded")]
        public DateTime DateUploaded { get; set; }

        [Display(Name = "EmployeeId")]
        public int EmployeeId { get; set; }


    }


    //public class ChartDataClass
    //{
    //    public DateTime ExecutionDate { get; set; }
    //    public double ExecutionValue { get; set; }
    //}


}