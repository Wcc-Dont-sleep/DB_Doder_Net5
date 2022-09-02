using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class MviewAdvFjg
    {
        public MviewAdvFjg()
        {
            MviewAdvGcs = new HashSet<MviewAdvGc>();
        }

        public decimal Fjgid { get; set; }
        public decimal Ajgid { get; set; }
        public decimal Fjgdeslen { get; set; }
        public byte[] Fjgdes { get; set; }
        public decimal Hashvalue { get; set; }
        public decimal? Frequency { get; set; }

        public virtual MviewAdvAjg Ajg { get; set; }
        public virtual ICollection<MviewAdvGc> MviewAdvGcs { get; set; }
    }
}
