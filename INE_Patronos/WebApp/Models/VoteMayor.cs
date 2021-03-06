﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class VoteMayor
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "The field datatime is required")]
        public DateTime DataTime { get; set; }

        [ForeignKey("Candidate")]
        [Required(ErrorMessage = "The field CveEnt is required")]
        public int IdCandidate { get; set; }
        public Candidate Candidate { get; set; }
    }
}