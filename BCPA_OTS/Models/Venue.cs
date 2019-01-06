using System;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// This is where the events are hosted.
    /// 
    /// Author: 
    /// </summary>
    public class Venue
    {
        /// <summary>
        /// 
        /// </summary>
        public string VenueID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int OpeningTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ClosingTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        //private Ticket ticket;

        //private Event event;

        //private Seat seat;

        //private Manager manager;

    }
}
