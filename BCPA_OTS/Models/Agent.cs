using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// The agent is responsible for selling tickets for specific seats.
    /// 
    /// Author: 
    /// 
    /// Assumption: An agent is an individual working for an entertainment 
    /// company, selling tickets. They will work in a location different 
    /// to the one that the venue is located in and sell a set number of 
    /// tickets to customers who come to their business.
    /// 
    /// Assumption: A ticket range applies to a set of seats for 
    /// a specific date range, not for specific shows.
    /// 
    /// Assumption: A date range will be assigned following a monthly 
    /// structure e.g. an agent will have their seat range for 2 months.
    /// </summary>
    public class Agent
    {
        /// <summary>
        /// A unique ID number given to each agent so 
        /// </summary>
        [ForeignKey("Person")]
        public int AgentID { get; set; }

        /// <summary>
        /// The seat range assigned to the agent, outlining the 
        /// range of seats they can sell as an agent.
        /// </summary>
        [Range(1,50)]
        public int SeatRange { get; set; }

        /// <summary>
        /// This refers to the date range given to the agent, 
        /// to sell thier assinged ticket range. 
        /// </summary>
        [Range(1, 3)]
        public DateTime DateRange { get; set; }

        public Ticket[] tickets;

    }
}
