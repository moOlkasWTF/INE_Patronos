using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Citizen
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Address")]
        [Required(ErrorMessage = "The field AddressId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field AddressId must be a number.")]
        public int AddressId { get; set; }

        [ForeignKey("Gender")]
        [Required(ErrorMessage = "The field GenderId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field GenderId must be a number.")]
        public int GenderId { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field Name is required")]
        [StringLength(15, ErrorMessage = "The field Name must have max length of 15 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Name must be a string")]
        public String Name { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field LastName is required")]
        [StringLength(30, ErrorMessage = "The field LastName must have max length of 30 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field LastName must be a string")]
        public String LastName { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field CURP is required")]
        [StringLength(25, ErrorMessage = "The field CURP must have max length of 25 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field CURP must be a string")]
        public String CURP { get; set; }

        [Required(ErrorMessage = "The field BirthDate is required")]
        public DateTime BirthDate { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field YearRegistration is required")]
        [StringLength(4, ErrorMessage = "The field YearRegistration must have max length of 4 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field YearRegistration must be a string")]
        public String YearRegistration { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field Section is required")]
        [StringLength(6, ErrorMessage = "The field Section must have max length of 6 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Section must be a string")]
        public String Section { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field Issue is required")]
        [StringLength(4, ErrorMessage = "The field Issue must have max length of 4 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Issue must be a string")]
        public String Issue { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field CIC is required")]
        [StringLength(15, ErrorMessage = "The field CIC must have max length of 15 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field CIC must be a string")]
        public String CIC { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field ElectroKey is required")]
        [StringLength(20, ErrorMessage = "The field ElectroKey must have max length of 20 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field ElectroKey must be a string")]
        public String ElectroKey { get; set; }
    }
}