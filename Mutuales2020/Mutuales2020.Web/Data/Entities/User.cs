﻿namespace Mutuales2020.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User : IdentityUser
    {

        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //[MaxLength(100, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        //public string Address { get; set; }

        //[Display(Name = "Phone Number")]
        //public override string PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }

        //[Display(Name = "Full Name")]
        //public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

        //[Display(Name = "Email Confirmed")]
        //public override bool EmailConfirmed { get => base.EmailConfirmed; set => base.EmailConfirmed = value; }

        //[NotMapped]
        //[Display(Name = "Is Admin?")]
        //public bool IsAdmin { get; set; }

    }
}