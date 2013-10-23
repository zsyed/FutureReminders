using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FutureReminders.Models
{

    public class PersonsContext : DbContext
    {
        public PersonsContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<PersonModels> PersonList { get; set; }
    }

    
    public class PersonModels
    {

        public int Id { get; set; }

        [ScaffoldColumn(false)]
        public string LoginName { get; set; }

        [Display(Name = "Name")]
        public string TextToName { get; set; }

        [Display(Name = "Cell Number")]
        public string TextToNumber { get; set; }
    }
}