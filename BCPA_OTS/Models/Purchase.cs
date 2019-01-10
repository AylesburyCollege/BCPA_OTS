using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCPA_OTS.Models
{
    public class Purchase
    {
        /// <summary>
        /// A unique number to identify each purchase.
        /// </summary>
        public int PurchaseID { get; set; }

        /// <summary>
        /// Refers to the date of purchase of a ticket, 
        /// present on a receipt of purchase, viewable on the 
        /// automated receipt e-mail sent to a customer.
        /// </summary>
        [Required, DataType(DataType.DateTime), Display(Name = "Date of Purchase")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        
        public bool EmailSent { get; set; }

        /// <summary>
        /// Refers to the date when the ticket was dispatched
        /// to the customer's address. 
        /// </summary>
        [Required, DataType(DataType.DateTime), Display(Name = "Date of Ticket Dispatch")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yy}", ApplyFormatInEditMode = true)]
        public DateTime DateTicketSent { get; set; }

        public int PersonID { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public virtual Person Person { get; set; }

    }
}
