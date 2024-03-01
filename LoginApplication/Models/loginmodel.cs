using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Helpers;

namespace LoginApplication.Models
{
    public class loginmodel
    {
        [Required (ErrorMessage = "Please Enter Your Email !")]
        [EmailAddress(ErrorMessage = "Email cannot be longer than 50 characters.")]
        [Display (Name ="Enter Email :")]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Email cannot be longer than 50 characters.")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Please Enter Your Password !")]
        [Display (Name = "Enter Password :")]
        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "Password cannot be longer than 20 characters.")]
        public string Password { get; set; }
    }
}