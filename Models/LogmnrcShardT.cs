using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrcShardT
    {
        public decimal LogmnrUid { get; set; }
        public string TablespaceName { get; set; }
        public decimal ChunkNumber { get; set; }
        public decimal StartScn { get; set; }
        public decimal? DropScn { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public string Spare3 { get; set; }
    }
}
