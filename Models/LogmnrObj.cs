using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrObj
    {
        public decimal? Objv { get; set; }
        public decimal? Owner { get; set; }
        public string Name { get; set; }
        public decimal? Namespace { get; set; }
        public string Subname { get; set; }
        public decimal? Type { get; set; }
        public Guid? Oid { get; set; }
        public string Remoteowner { get; set; }
        public string Linkname { get; set; }
        public decimal? Flags { get; set; }
        public decimal? Spare3 { get; set; }
        public DateTime? Stime { get; set; }
        public decimal Obj { get; set; }
        public decimal? LogmnrUid { get; set; }
        public decimal? LogmnrFlags { get; set; }
        public decimal? StartScnbas { get; set; }
        public decimal? StartScnwrp { get; set; }
    }
}
