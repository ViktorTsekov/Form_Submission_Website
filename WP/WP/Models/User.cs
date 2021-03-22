using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WP.Models
{
    public class User : IdentityUser
    {
        public string Role { get; set; } = "User";
        public List<Form> Forms { get; set; }
    }
}
