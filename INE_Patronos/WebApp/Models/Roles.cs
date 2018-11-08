using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Roles
    {
        [Key]
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field President is required")]
        [StringLength(30, ErrorMessage = "The field President must have max length of 30 characters")]
        public String President { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field Governor is required")]
        [StringLength(30, ErrorMessage = "The field Governor must have max length of 30 characters")]
        public String Governor { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field Mayor is required")]
        [StringLength(30, ErrorMessage = "The field Mayor must have max length of 30 characters")]
        public String Mayor { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
    }
}