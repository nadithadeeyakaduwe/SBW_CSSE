using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Entities.HRMModule
{
    public sealed class EmployeeAttendanceDto
    {
        public int EmployeeID { get; set; }

        public DateTime InTime { get; set; }

        public DateTime? OutTime { get; set; }

        public TimeSpan? LateTime { get; set; }

        public double? Duration { get; set; }

        public string InNote { get; set; }

        public string OutNote { get; set; }

        public int? Status { get; set; }

        public DateTime ModifiedDate { get; set; }

        public DateTime DateCreated { get; set; }

        public DataTable PastAttendanceRecords { get; set; }

    }
}
