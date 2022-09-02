using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogstdbyScn
    {
        public decimal? Obj { get; set; }
        public string Objname { get; set; }
        public string Schema { get; set; }
        public string Type { get; set; }
        public decimal? Scn { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public string Spare3 { get; set; }
    }
}
