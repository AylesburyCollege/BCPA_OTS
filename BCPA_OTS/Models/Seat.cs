using System;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
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
        /// A specification of seat that each one will 
        /// have. The types are: Orchestra, Stall and 
        /// Back seat.
        /// </summary>
        [Required, StringLength(10), Display(Name ="Seat Type")]
        public string Type { get; set; }

        /// <summary>
        /// A true of false statement which states whether or not
        /// the seat is an aisle seat or not
        /// </summary>
        [Display(Name ="Aisle Seat")]
        public bool AisleSeat { get; set; }

        //private Venue venue;

        //private Ticket[] tickets;

    }
}
