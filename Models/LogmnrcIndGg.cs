﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrcIndGg
    {
        public decimal LogmnrUid { get; set; }
        public decimal Obj { get; set; }
        public string Name { get; set; }
        public decimal CommitScn { get; set; }
        public decimal? DropScn { get; set; }
        public decimal Baseobj { get; set; }
        public decimal Baseobjv { get; set; }
        public decimal Flags { get; set; }
        public decimal Owner { get; set; }
        public string Ownername { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public string Spare4 { get; set; }
        public string Spare5 { get; set; }
        public string Spare6 { get; set; }
    }
}
