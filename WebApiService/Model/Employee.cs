using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Model
{
    public class Employee
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="should be less than 50")]
        public string name { get; set; }
    }
}
