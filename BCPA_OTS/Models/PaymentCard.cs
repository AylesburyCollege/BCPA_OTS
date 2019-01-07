using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCPA_OTS.Models
{
    public class PaymentCard
    {
        [ForeignKey("Person")]
        public int PaymentCardID { get; set; }

        /// <summary>
        /// The 16 digits on the front of the card, displayed
        /// above the start and expiry date.
        /// </summary>
        [Required, StringLength(16), Display(Name = "Card Number")]
        public int CardNumber { get; set; }

        /// <summary>
        /// The expiry date of the credit card, displayed beside 
        /// the start date. The expiry date is formatted as mm/yy/
        /// </summary>
        [Required, DataType(DataType.Date), Display(Name = "Date of Expiry")]
        [DisplayFormat(DataFormatString="{0:MM/yy}", ApplyFormatInEditMode = true)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// The 3 digits on the back of the card, viewable on
        /// the strip where the signature is viewed.
        /// </summary>
        [Required, StringLength(3), Display(Name = "Security Code")]
        public string SecurityNumber { get; set; }

       //private Person Person;

    }
}
