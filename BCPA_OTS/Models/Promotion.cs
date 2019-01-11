using System;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    public enum TicketOptions
    {
        NONE,
        [Display(Name = "Adult")]
        ADULT,
        [Display(Name = "Student")]
        STUDENT,
        [Display(Name = "Child")]
        CHILD,
        [Display(Name = "Senior")]
        SENIOR,
    }

    public class Promotion
    {
        /// <summary>
        /// A unique number to identify the pricing structure.
        /// Author: Daniel
        /// </summary>
        public int PromotionID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Range(0, 100, ErrorMessage = "Must be a % between 0 and 90")]
        public int AdultDiscount { get; set; }

        [Range(0, 100, ErrorMessage = "Must be a % between 0 and 90")]
        public int StudentDiscount { get; set; }

        [Range(0, 100, ErrorMessage = "Must be a % between 0 and 90")]
        public int ChildDiscount { get; set; }

        [Range(0, 100, ErrorMessage = "Must be a % between 0 and 90")]
        public int SeniorDiscount { get; set; }

    }
}
