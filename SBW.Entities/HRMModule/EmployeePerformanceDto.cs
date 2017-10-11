using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Entities.HRMModule
{
    public sealed class EmployeePerformanceDto
    {
        /// <summary>
        /// Gets or sets the employee details.
        /// </summary>
        /// <value>
        /// The employee details.
        /// </value>
        public Employee EmployeeDetails { get; set; }
        
        /// <summary>
        /// Gets or sets the performance.
        /// </summary>
        /// <value>
        /// The performance.
        /// </value>
        public DataTable PerformanceTable { get; set; }
    }
}
