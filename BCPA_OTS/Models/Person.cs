using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// The person who wishes to attend events 
    /// and shows at the venue.
    /// 
    /// Author: Zeeshan
    /// </summary>
    public class Person
    {
        /// <summary>
        /// A unique number used to identify customers.
        /// </summary>
        [Key]
        public int PersonID { get; set; }

        /// <summary>
        /// The first name of any given person.
        /// </summary>
        [Required, StringLength(20), Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last or surname of any given person.
        /// </summary>
        [Required, StringLength(20), Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// The e-mail held by a person by which they can be contacted
        /// and the email address used to register the customer online account.
        /// </summary>
        [Required, StringLength(100), Display(Name = "E-mail Address")]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of a person, assigned to a home phone.
        /// </summary>
        [StringLength(20), DataType(DataType.PhoneNumber), Display(Name = "Home Phone")]
        public string HomePhoneNumber { get; set; }

        /// <summary>
        /// The phone number of a person, assigned to their mobile phone.
        /// </summary>
        [StringLength(20), DataType(DataType.PhoneNumber), Display(Name = "Mobile Phone")]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// The date of birth of the person
        /// </summary>
        [Required, DataType(DataType.DateTime), Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy/mm/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        // Navigation Properties

        public int PaymentCardID { get; set; }
        public virtual PaymentCard PaymentCard { get; set; }

        public int AddressID { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }

        // Methods

        /// <summary>
        /// Used to register and store the customers information so the 
        /// customer can login using the created credentials if they 
        /// haven't already registered, as well as so the address can 
        /// be stored so tickets and promotions can be sent
        /// 
        /// DSS
        /// </summary>
        public void RegisterCustomer()
        {
            throw new System.Exception("Not implemented");
        }

    }
}
