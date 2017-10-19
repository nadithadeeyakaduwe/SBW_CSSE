namespace SBW.Entities.HRMModule
{
    public sealed class EmployeePromotionDto
    {
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Gets or sets the new position identifier.
        /// </summary>
        /// <value>
        /// The new position identifier.
        /// </value>
        public int NewPositionID { get; set; }

        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>
        /// The reason.
        /// </value>
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the new salary.
        /// </summary>
        /// <value>
        /// The new salary.
        /// </value>
        public decimal NewSalary { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public int Status { get; set; }
    }
}
