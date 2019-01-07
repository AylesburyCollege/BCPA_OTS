using System;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    public class PricingStructure
    {
        /// <summary>
        /// A unique number to identify the pricing structure.
        /// </summary>
        public int PricingStructureID { get; set; }

        /// <summary>
        /// The ticket price for an adult.
        /// </summary>
        [Required, DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true)]
        [Display(Name = "Adult Ticket Price")]
        public decimal AdultTicketPrice { get; set; }

        /// <summary>
        /// The ticket price for a student.
        /// </summary>
        [Required, DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true)]
        [Display(Name = "Student Ticket Price")]
        public decimal StudentTicketPrice { get; set; }

        /// <summary>
        /// The ticket price for a child
        /// </summary>
        [Required, DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true)]
        [Display(Name = "Child Ticket Price")]
        public decimal ChildTicketPrice { get; set; }

        /// <summary>
        /// The ticket price for a senior citizen
        /// </summary>
        [Required, DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true)]
        [Display(Name = "Senior Ticket Price")]
        public decimal SeniorTicketPrice { get; set; }

        //private Event Event;

    }
}
