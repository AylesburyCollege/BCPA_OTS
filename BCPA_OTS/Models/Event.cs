using System;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// Author: William Foster
    /// 
    /// Assumption: Events do not have an interval as the 
    /// attendees can attend or leave whenever they wish.
    /// Additionally, I am assuming that all shows will 
    /// have an interval of up to minutes.
    /// </summary>
    public class Event
    {
        public int EventID { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        /// <summary>
        /// The starting time of the event, displayed in
        /// a 24 hour clock format e.g. 19:00.
        /// </summary>
        [Required, DataType(DataType.DateTime), Display(Name= "Starting Time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The ending time of the event, displayed in 
        /// a 24 hour clock format e.g. 22:00
        /// </summary>
        [DataType(DataType.DateTime), Display(Name = "Finishing Time")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// In the case of a show, this is a space of time 
        /// where the performance will pause for the audience 
        /// to have a break. 
        /// </summary>
        [Range(15, 30), DataType(DataType.Time)]
        public DateTime Interval { get; set; }

        /// <summary>
        ///  A measure of the duration of the event, 
        ///  measured in hours and minutes, counting
        ///  an interval time e.g. 2:30.
        /// </summary>
        [Required, DataType(DataType.DateTime)]
        public DateTime EventDuration { get; set; }

        /// <summary>
        /// The URL of the image being used in the event's 
        /// decrption, e.g. an image of a representative 
        /// or company attending the event.
        /// </summary>
        [Required, StringLength(255), DataType(DataType.ImageUrl), Display(Name="Image")]
        public string ImageURL { get; set; }

        /// <summary>
        /// The URL of a video being played on the event's
        /// details page. In the case of an event, it may 
        /// be an informative video of what the event will 
        /// be about and its schedule.
        /// </summary>
        [Required, StringLength(255), DataType(DataType.Url), Display(Name = "Video")]
        public string VideoURL { get; set; }

        /// <summary>
        /// A short description of the event 
        /// and its contents.
        /// </summary>
        [Required, StringLength(500)]
        public string Description { get; set; }

        /// <summary>
        /// A true or false statement that identifies 
        /// the event as a show or an event.
        /// </summary>
        public bool IsShow { get; set; }

        private Ticket[] tickets;

        //private PricingStructure PricingStructure;

        private Artist[] Artists;

    }
}
