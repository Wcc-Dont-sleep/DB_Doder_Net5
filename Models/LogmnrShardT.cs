using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrShardT
    {
        public decimal LogmnrUid { get; set; }
        public string TablespaceName { get; set; }
        public decimal ChunkNumber { get; set; }
        public decimal? StartScnbas { get; set; }
        public decimal? StartScnwrp { get; set; }
    }
}
