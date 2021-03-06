﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("PoliticalParty")]
        [Required(ErrorMessage = "The field CveEnt is required")]
        public int PoliticalPartyId { get; set; }
        public PoliticalParty PoliticalParty { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field Rol is required")]
        [StringLength(50, ErrorMessage = "The field Rol must have max length of 50 characters")]
        public String Rol { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field Name is required")]
        [StringLength(50, ErrorMessage = "The field Name must have max length of 15 characters")]
        public String Name { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field LastName is required")]
        [StringLength(30, ErrorMessage = "The field LastName must have max length of 30 characters")]
        public String LastName { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field Age is required")]
        [StringLength(10, ErrorMessage = "The field Age must have max length of 10 characters")]
        public String Age { get; set; }

        public virtual ICollection<VotePresident> VotePresidents { get; set; }
        public virtual ICollection<VoteGovernor> VoteGovernors { get; set; }
        public virtual ICollection<VoteMayor> VoteMayors { get; set; }

    }

}