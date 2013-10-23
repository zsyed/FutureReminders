using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FutureReminders.Models
{
    public class Contact
    {

        public int Id { get; set; }

        [ScaffoldColumn(false)]
        public string LoginName { get; set; }

        [Display(Name = "Name")]
        public string TextToName { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

    }
}