using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// The agent is responsible for selling tickets for specific seats.
    /// 
    /// Author: Daniel
    /// 
    /// Assumption: An agent is an individual working for an entertainment 
    /// company, selling tickets. They will work in a location different 
    /// to the one that the venue is located in and sell a set number of 
    /// tickets to customers who come to their business.
    /// 
    /// Assumption: A ticket range applies to a set of seats for 
    /// a specific date range, not for specific shows. This range
    /// will be defined by a continuous set of seat rows (A:Z, 1:26)
    /// 
    /// Assumption: A date range will be assigned following a monthly 
    /// structure e.g. an agent will have their seat range for 2 months.
    /// </summary>
    public class Agent
    {
        /// <summary>
        /// A unique ID number given to each agent so 
        /// </summary>
        [Key]
        [ForeignKey("Person")]
        public int AgentID { get; set; }

        /// <summary>
        /// The first row this agent can sell for shows during the
        /// period of the contract
        /// </summary>
        [Range(1,20)]
        public int StartRow { get; set; }

        /// <summary>
        /// The last row this agent can sell for shows during the
        /// period of the contract
        /// </summary>
        [Range(1, 20)]
        public int EndRow { get; set; }

        /// <summary>
        /// This is the first date that the agent can sell
        /// selected seats to shows at the venue
        /// </summary>
        [DataType(DataType.Date)]
         public DateTime ContractStartDate { get; set; }

        /// <summary>
        /// This is the first date that the agent can sell
        /// selected seats to shows at the venue
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime ContractEndDate { get; set; }

        [Range(1, 100)]
        public int Comission { get; set; }

        // Navigation Properties

        public virtual Person Person { get; set; }
    }
}
