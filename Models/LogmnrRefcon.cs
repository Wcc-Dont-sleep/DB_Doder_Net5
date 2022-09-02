using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrRefcon
    {
        public decimal? Col { get; set; }
        public decimal? Intcol { get; set; }
        public decimal? Reftyp { get; set; }
        public Guid? Stabid { get; set; }
        public Guid? Expctoid { get; set; }
        public decimal Obj { get; set; }
        public decimal? LogmnrUid { get; set; }
        public decimal? LogmnrFlags { get; set; }
    }
}
