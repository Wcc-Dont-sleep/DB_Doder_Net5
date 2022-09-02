using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class RollingDirective
    {
        public decimal? Directid { get; set; }
        public decimal? Phase { get; set; }
        public decimal? Taskid { get; set; }
        public string Feature { get; set; }
        public string Description { get; set; }
        public decimal? Target { get; set; }
        public string Flags { get; set; }
        public decimal? Opcode { get; set; }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public string Spare3 { get; set; }
    }
}
