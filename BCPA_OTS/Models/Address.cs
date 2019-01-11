using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// Author: Zeeshan
    /// </summary>

    public enum Counties
    {
        [Display(Name = "Buckinghamshire")]
        BUCKINGHAMSHIRE,
        [Display(Name = "Bedfordshire")]
        BEDFORDSHIRE,
        [Display(Name = "Hertfordshire")]
        HERTFORDSHIRE,
        [Display(Name = "London")]
        LONDON,
        [Display(Name = "Northamtonshire")]
        NORTHAMTONSHIRE,
        [Display(Name = "Oxfordshire")]
        OXFORDSHIRE
    }

    /// <summary>  
    /// Assumption: The delivery address of customers will be the same as their billing address.
    /// </summary>
    public class Address
    {
        [ForeignKey("Person")]
        public int AddressID { get; set; }

        /// <summary>
        /// Refers to a person's house number or name. 
        /// </summary>
        [Required, StringLength(20), Display(Name = "House Number/Name")]
        public string House { get; set; }

        /// <summary>
        /// Refers to the street the person lives on.
        /// </summary>
        [Required, StringLength(30), Display(Name = "Street Name")]
        public string Street { get; set; }

        /// <summary>
        /// The town where the person lives.
        /// </summary>
        [StringLength(30)]
        public string Town { get; set; }

        /// <summary>
        /// Refers to the postcode allocated to the person's address.
        /// </summary>
        [Required, StringLength(10)]
        public string Postcode { get; set; }

        /// <summary>
        /// Refers to the county the person lives within. 
        /// </summary>
        public Counties County { get; set; }

        public virtual Person Person { get; set; }

    }
}
