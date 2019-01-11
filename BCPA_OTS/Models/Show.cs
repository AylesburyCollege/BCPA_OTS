using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// Author: William Foster
    /// </summary>
    public class Show
    {
        /// <summary>
        /// A unique number given to each show 
        /// in order to identify it.
        /// </summary>
        public int ShowID { get; set; }

        /// <summary>
        /// The starting time of the event, displayed in
        /// a 24 hour clock format e.g. 19:00.
        /// </summary>
        [Required, DataType(DataType.DateTime), Display(Name = "Starting Time")]
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// The ending time of the event, displayed in 
        /// a 24 hour clock format e.g. 22:00
        /// </summary>
        [DataType(DataType.DateTime), Display(Name = "Finishing Time")]
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// In the case of a show, this is time of a 20 minute interval 
        /// where the performance will pause for the audience to have a break. 
        /// </summary>
        [DataType(DataType.Time)]
        public DateTime IntervalTime { get; set; }

        // Events are shows that only occur once, and tickets cannot
        // be purchased online.  They are bought at the door
        public bool HasTickets { get; set; }

        // Navigation Properties

        public int PromotionID { get; set; }
        public Promotion Promotion { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }

    }
}
