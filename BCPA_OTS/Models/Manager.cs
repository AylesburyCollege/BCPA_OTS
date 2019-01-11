using System;
namespace BCPA_OTS.Models
{
    /// <summary>
    /// The manager is in charge of overseeing the venue.
    /// 
    /// Author: 
    /// </summary>

    public class Manager
    {
        /// <summary>
        /// A unique number assigned to the manager.
        /// </summary>
        public int ManagerID { get; set; }

        /// <summary>
        /// A process the manager can start to cancel a show. 
        /// A show may need to be cancelled due to elements out 
        /// of the manager's and production team's contorol.
        /// </summary>
        public void CancelEvent()
        {
            throw new System.Exception("Not implemented");
        }

        /// <summary>
        /// The process of an event being rescheduled. This 
        /// may need to occur if a show had to be halted for one 
        /// day but can still be produced for future days.
        /// </summary>
        public void RescheduleEvent()
        {
            throw new System.Exception("Not implemented");
        }

        /// <summary>
        /// The process of adding an event to the events listing.
        /// </summary>
        public void AddEvent()
        {
            throw new System.Exception("Not implemented");
        }

        /// <summary>
        /// The process of the manager setting the seat limit for a
        /// show. Following other theatre examples, we are assuming 
        /// that the theatre will have 200 seats. 
        /// </summary>
        public void CreateSeatLimit()
        {
            throw new System.Exception("Not implemented");
        }

        /// <summary>
        /// Before an event is viewable on the website, the manager will apply a pricing structure for it. 
        /// This will layout the prices for the different seat types:
        ///  - Orchestra seats will be the most expensive seats,
        ///  - followed by stalls, 
        ///  - and back seats which tend to be the most affordable seats.
        /// </summary>
        public void ApplyPricingStructure()
        {
            throw new System.Exception("Not implemented");
        }


    }
}
