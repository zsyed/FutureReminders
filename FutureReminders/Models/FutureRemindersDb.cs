using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FutureReminders.Models
{
    public class FutureRemindersDb : DbContext
    {
        public FutureRemindersDb()
            : base("DefaultConnection")
        {
        }
        public DbSet<Contact> ContactsList { get; set; }
    }
}