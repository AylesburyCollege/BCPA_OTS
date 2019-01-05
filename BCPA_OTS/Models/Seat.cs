using System;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// William Foster
    /// </summary>
    public class Seat
    {
        /// <summary>
        /// An identification number assigned to 
        /// each seat that combines its seat and row 
        /// number.
        /// </summary>
        public string SeatID { get; set; }

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
