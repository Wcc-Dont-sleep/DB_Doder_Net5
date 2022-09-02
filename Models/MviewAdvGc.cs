using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class MviewAdvGc
    {
        public decimal Gcid { get; set; }
        public decimal Fjgid { get; set; }
        public decimal Gcdeslen { get; set; }
        public byte[] Gcdes { get; set; }
        public decimal Hashvalue { get; set; }
        public decimal? Frequency { get; set; }

        public virtual MviewAdvFjg Fjg { get; set; }
    }
}
