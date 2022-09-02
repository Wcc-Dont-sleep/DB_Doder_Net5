using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogstdbySkipTransaction
    {
        public decimal? Xidusn { get; set; }
        public decimal? Xidslt { get; set; }
        public decimal? Xidsqn { get; set; }
        public decimal? Active { get; set; }
        public decimal? CommitScn { get; set; }
        public decimal? Spare2 { get; set; }
        public string Spare3 { get; set; }
        public string ConName { get; set; }
    }
}
