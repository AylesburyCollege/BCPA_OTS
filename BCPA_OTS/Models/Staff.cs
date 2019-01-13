using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCPA_OTS.Models
{
    /// <summary>
    /// Author: Zeeshan
    /// </summary>

    public enum DepartmentOptions
    {
        [Display(Name = "Sales")]
        SALES,
        [Display(Name = "Marketing")]
        MARKETING,
        [Display(Name = "Management")]
        MANAGEMENT
    }

    public enum JobPositionOptions
    {
        [Display(Name = "Sales Assisstant")]
        SALES_ASSISSTANT,
        [Display(Name = "Sales Manager")]
        SALES_MANAGER,
        [Display(Name = "Head of Marketing")]
        HEAD_OF_MARKETING,
        [Display(Name = "Marketing Assisstant")]
        MARKETING_ASSISSTANT,
        [Display(Name = "Head Manager")]
        HEAD_MANAGER,
        [Display(Name = "Deputy Manager")]
        DEPUTY_MANAGER
    }

    public class Staff
    {
        /// <summary>
        /// A specific identification number that can 
        /// identify the member of staff within a database.
        /// </summary>
        [Key]
        [ForeignKey("Person")]
        public int StaffID { get; set; }

        /// <summary>
        /// The department that the member of staff works for e.g.
        /// sales, marketing or management.
        /// </summary>
        public DepartmentOptions Department { get; set; }

        /// <summary>
        /// The specific position that the member of staff holds within 
        /// their department, e.g. sales assisstant or marketer.
        /// </summary>
        [Display(Name = "Job Role")]
        public JobPositionOptions JobRole { get; set; }

        /// <summary>
        /// The annual amount of money earned by a staff member.
        /// </summary>
        public decimal Salary { get; set; }

        public Person Person { get; set; }

    }
}
