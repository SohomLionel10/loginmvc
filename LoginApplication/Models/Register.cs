using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Helpers;

namespace LoginApplication.Models
{
    public class Register
    {
        public string Salutation {  get; set; }

        [Required(ErrorMessage = "Please Enter Your Firstname !")]
        [Display(Name = "Firstname")]
        [DataType(DataType.Text)]
        public string Firstname { get; set; }

        public string Middlename { get; set; }

        [Required(ErrorMessage = "Please Enter Your Lastname !")]
        [Display(Name = "Lastname")]
        [DataType(DataType.Text)]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please Choose Qualification !")]
        [Display(Name = "Qualification")]
        [DataType(DataType.Text)]
        public string Qualification { get; set; }

        public string Stream { get; set; }

        [Required(ErrorMessage = "Please Choose Date of Birth !")]
        [Display(Name = "DOB")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public int? Age {  get; set; }

        [Display(Name = "Are you currently working?")]
        public bool IsWorking { get; set; }

        [Required(ErrorMessage = "Please Agree to Terms and Conditions !")]
        public bool AgreeTerms { get; set; }

    }
}