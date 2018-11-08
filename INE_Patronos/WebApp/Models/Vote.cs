using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Candidate")]
        [Required(ErrorMessage = "The field CandidateId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field CandidateId must be a number.")]
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public DateTime DateTime { get; set; } 
    }
}