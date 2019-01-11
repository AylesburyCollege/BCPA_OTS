using System;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// Author:  
    /// </summary>

    public class Artist
    {
        // A unique name registered for each artist.
        [StringLength(50)]
        public string ArtistID { get; set; }

        /// <summary>
        /// A description of the artist and the kind of 
        /// performance they provide.
        /// </summary>
        [Required, StringLength(500)]
        public string Description { get; set; }
        
        /// <summary>
        /// An image of the artist to be displayed on 
        /// their events page.
        /// </summary>
        [Required, StringLength(255), DataType(DataType.Url)]
        public string ImageURL { get; set; }

        //private Event[] Events;

    }
}
