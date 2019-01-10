using System;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    public enum TicketOptions
    {
        [Display(Name = "Adult")]
        ADULT,
        [Display(Name = "Student")]
        STUDENT,
        [Display(Name = "Child")]
        CHILD,
        [Display(Name = "Senior")]
        SENIOR,
    }

    public class PricingStructure
    {
        /// <summary>
        /// A unique number to identify the pricing structure.
        /// </summary>
        public int PricingStructureID { get; set; }

        /// <summary>
        /// The various ticket options for customers, depending 
        /// on their age or circumstance.
        /// </summary>
        [Display(Name = "Ticket Options")]
        public TicketOptions Ticket { get; set; }

        //private Event Event;

    }
}
