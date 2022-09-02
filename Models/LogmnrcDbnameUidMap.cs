using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrcDbnameUidMap
    {
        public string GlobalName { get; set; }
        public decimal? LogmnrUid { get; set; }
        public decimal? Flags { get; set; }
        public string PdbName { get; set; }
        public decimal LogmnrMdh { get; set; }
    }
}
