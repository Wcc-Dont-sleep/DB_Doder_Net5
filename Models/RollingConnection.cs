using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class RollingConnection
    {
        public decimal? SourceRdbid { get; set; }
        public decimal? DestRdbid { get; set; }
        public decimal? Attributes { get; set; }
        public string ServiceName { get; set; }
        public decimal? ConnHandle { get; set; }
        public DateTime? ConnectTime { get; set; }
        public DateTime? SendTime { get; set; }
        public DateTime? DisconnectTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public decimal? SourcePid { get; set; }
        public decimal? DestPid { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public string Spare3 { get; set; }
    }
}
