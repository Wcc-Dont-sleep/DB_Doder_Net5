using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrCon
    {
        public decimal Owner { get; set; }
        public string Name { get; set; }
        public decimal Con { get; set; }
        public decimal? LogmnrUid { get; set; }
        public decimal? LogmnrFlags { get; set; }
        public decimal? StartScnbas { get; set; }
        public decimal? StartScnwrp { get; set; }
    }
}
