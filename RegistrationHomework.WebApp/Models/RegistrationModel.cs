using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationHomework.WebApp.Models
{
    public class RegistrationModel
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [Range(0, 100)]
        public string Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
