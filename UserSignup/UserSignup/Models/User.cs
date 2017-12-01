using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class User
    {
        [Required]// apply only for User
        public string Username { get; set; }

        [Required]// apply only for User
        public string Email { get; set; }

        public string Password {get; set;}
    }
}
