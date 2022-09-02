using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogstdbyPlsql
    {
        public decimal? SessionId { get; set; }
        public decimal? StartFinish { get; set; }
        public string CallText { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public string Spare3 { get; set; }
    }
}
