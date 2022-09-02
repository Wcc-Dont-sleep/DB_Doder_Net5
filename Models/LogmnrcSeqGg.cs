using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrcSeqGg
    {
        public decimal LogmnrUid { get; set; }
        public decimal Obj { get; set; }
        public decimal CommitScn { get; set; }
        public decimal? DropScn { get; set; }
        public decimal SeqFlags { get; set; }
        public decimal Owner { get; set; }
        public string Ownername { get; set; }
        public string Objname { get; set; }
        public decimal? Seqcache { get; set; }
        public decimal? Seqinc { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public string Spare3 { get; set; }
        public string Spare4 { get; set; }
    }
}
