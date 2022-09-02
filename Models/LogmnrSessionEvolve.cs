using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrSessionEvolve
    {
        public decimal? BranchLevel { get; set; }
        public decimal Session { get; set; }
        public decimal DbId { get; set; }
        public decimal ResetScn { get; set; }
        public decimal ResetTimestamp { get; set; }
        public decimal? PrevResetScn { get; set; }
        public decimal? PrevResetTimestamp { get; set; }
        public decimal? Status { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public DateTime? Spare4 { get; set; }
    }
}
