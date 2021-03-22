using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WP.Models
{
    public class Form
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Status { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public int FacultyNumber { get; set; }
        public string Lnch { get; set; }
        public string Egn { get; set; }
        public string Subject { get; set; }
        public string Course { get; set; }
        public string TextField { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime LastYear { get; set; }
        public string Term { get; set; }
        public string StudyForm { get; set; }
        public string Degree { get; set; }
        public string Reason { get; set; }
        public string StudentType { get; set; }

        public User User { get; set; }

    }
}
