using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrSubcoltype
    {
        public decimal Intcol { get; set; }
        public Guid Toid { get; set; }
        public decimal Version { get; set; }
        public decimal? Intcols { get; set; }
        public byte[] IntcolS1 { get; set; }
        public decimal? Flags { get; set; }
        public decimal? Synobj { get; set; }
        public decimal Obj { get; set; }
        public decimal? LogmnrUid { get; set; }
        public decimal? LogmnrFlags { get; set; }
    }
}
