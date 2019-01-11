using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// Author: William Foster
    /// 
    /// Assumption: Events do not have an interval as the 
    /// attendees can attend or leave whenever they wish.
    /// Additionally, I am assuming that all shows will 
    /// have an interval of 20 minutes.
    /// </summary>
    public class Event
    {
        public int EventID { get; set; }

        /// <summary>
        /// The displayed name of the event, present on the 
        /// events list.
        /// </summary>
        [Required, StringLength(30)]
        public string Name { get; set; }

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
        /// the event as a show or an event.  Shows have
        /// multiple performances
        /// </summary>
        public bool IsShow { get; set; }

        // Navigation Properties

        public virtual ICollection<Artist> Artists { get; set; }

    }
}
