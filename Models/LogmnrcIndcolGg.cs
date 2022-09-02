using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrcIndcolGg
    {
        public decimal LogmnrUid { get; set; }
        public decimal Obj { get; set; }
        public decimal CommitScn { get; set; }
        public decimal Intcol { get; set; }
        public decimal Pos { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public string Spare3 { get; set; }
    }
}
