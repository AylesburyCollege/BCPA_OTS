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
        /// A short description of the show and its
        /// contents.
        /// </summary>
        [Required, StringLength(500)]
        public string Description { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) of the
        /// image being used in the show's decrption,
        /// i.e. an image relevant to a specific show.
        /// </summary>
        [Required, StringLength(255), DataType(DataType.ImageUrl), Display(Name ="Image")]
        public string ImageURL { get; set; }

        /// <summary>
        /// The URL of the video being used in the show's 
        /// description e.g. a trailer for the show with 
        /// preview viewing from various venues.
        /// </summary>
        [Required, StringLength(255), DataType(DataType.Url), Display(Name ="Video")]
        public string VideoURL { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }

    }
}
