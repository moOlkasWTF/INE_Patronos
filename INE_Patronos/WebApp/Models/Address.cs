using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Address")]
        [Required(ErrorMessage = "The field AddressId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field AddressId must be a number.")]
        public int CountryRegionId { get; set; }
        public CountryRegion CountryRegion { get; set; }

        [ForeignKey("Address")]
        [Required(ErrorMessage = "The field AddressId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field AddressId must be a number.")]
        public int StateProvinceId { get; set; }
        public StateProvince StateProvince { get; set; }

        [ForeignKey("Address")]
        [Required(ErrorMessage = "The field AddressId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field AddressId must be a number.")]
        public int CityId { get; set; }
        public City City { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field Street is required")]
        [StringLength(30, ErrorMessage = "The field Street must have max length of 30 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Street must be a string")]
        public String Street { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "The field Number is required")]
        [StringLength(8, ErrorMessage = "The field Number must have max length of 8 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Number must be a string")]
        public String  Number { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }



    }
}