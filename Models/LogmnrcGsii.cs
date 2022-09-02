using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrcGsii
    {
        public decimal LogmnrUid { get; set; }
        public decimal Obj { get; set; }
        public decimal Bo { get; set; }
        public decimal Indtype { get; set; }
        public decimal? DropScn { get; set; }
        public decimal? LogmnrSpare1 { get; set; }
        public decimal? LogmnrSpare2 { get; set; }
        public string LogmnrSpare3 { get; set; }
        public DateTime? LogmnrSpare4 { get; set; }
    }
}
