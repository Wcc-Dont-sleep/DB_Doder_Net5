using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrLobfrag
    {
        public decimal? Fragobj { get; set; }
        public decimal? Parentobj { get; set; }
        public decimal? Tabfragobj { get; set; }
        public decimal? Indfragobj { get; set; }
        public decimal Frag { get; set; }
        public decimal? LogmnrUid { get; set; }
        public decimal? LogmnrFlags { get; set; }
    }
}
