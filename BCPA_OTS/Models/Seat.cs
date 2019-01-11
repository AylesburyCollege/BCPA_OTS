using System;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    public enum SeatTypes
    {
        Orchestra,
        FrontStalls,
        BackStalls
    }

    /// <summary>
    /// Author: William Foster
    /// </summary>
    public class Seat
    {
        /// <summary>
        /// An identification number assigned to 
        /// each seat.
        /// </summary>
        public int SeatID { get; set; }

        /// <summary>
        /// A letter assigned to each row. The seat
        /// number followed by the row letter informs 
        /// the customer of their specific seat.
        /// </summary>
        public string RowLetter { get; set; }

        /// <summary>
        /// Seats in a Row are numbered from 1 on the left hand
        /// side facing the back
        /// </summary>
        public int SeatNo { get; set; }
        /// <summary>
        /// A specification of seat that each one will 
        /// have. The types are: Orchestra, Stall and 
        /// Back seat.
        /// </summary>
        [Required, Display(Name ="Seat Type")]
        public SeatTypes Type { get; set; }

        /// <summary>
        /// A true of false statement which states whether or not
        /// the seat is an aisle seat or not
        /// </summary>
        [Display(Name ="Aisle Seat")]
        public bool AisleSeat { get; set; }

        /// <summary>
        /// The various ticket options for customers, depending 
        /// on their age or circumstance.
        /// </summary>
        [Display(Name = "Ticket Options")]
        public TicketOptions Ticket { get; set; }

        // Navigation Properties

        public int ShowID { get; set; }
        public virtual Show Show { get; set; }

        public Nullable<int> PurchaseID { get; set; }
        public virtual Purchase Purchase { get; set; }

        public Nullable<int> AgentID { get; set; }
        public virtual Agent Agent { get; set; }

    }
}
