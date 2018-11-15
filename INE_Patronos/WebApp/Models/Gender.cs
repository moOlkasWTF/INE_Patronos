using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field Man is required")]
        [StringLength(10, ErrorMessage = "The field Man must have max length of 10 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Man must be a string")]
        public String Man { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field Woman is required")]
        [StringLength(10, ErrorMessage = "The field Woman must have max length of 10 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Woman must be a string")]
        public String Woman { get; set; } 

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}