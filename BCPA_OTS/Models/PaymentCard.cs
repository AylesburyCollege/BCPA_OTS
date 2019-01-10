using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCPA_OTS.Models
{
    public class PaymentCard
    {
    
        [ForeignKey("Person")]
        public int PaymentCardID { get; set; }

        [StringLength(20), Required]
        public string HolderName { get; set; }

        /// <summary>
        /// The 16 digits on the front of the card, displayed
        /// above the start and expiry date.
        /// </summary>
        [Required, StringLength(16), Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        /// <summary>
        /// The expiry date of the credit card, displayed beside 
        /// the start date. The expiry date is formatted as mm/yy/
        /// </summary>
        [Range(1,12), Required]
        public int ExpiryMonth { get; set; }

        [Range(2019, 2025), Required]
        public int ExpiryYear { get; set; }

        /// <summary>
        /// The 3 digits on the back of the card, viewable on
        /// the strip where the signature is viewed.
        /// </summary>
        [Required, StringLength(3), Display(Name = "Security Code")]
        public string SecurityNumber { get; set; }

        public virtual Person Person { get; set; }

    }
}
