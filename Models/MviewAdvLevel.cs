using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class MviewAdvLevel
    {
        public MviewAdvLevel()
        {
            MviewAdvRollupMviewAdvLevelNavigations = new HashSet<MviewAdvRollup>();
            MviewAdvRollupMviewAdvLevels = new HashSet<MviewAdvRollup>();
        }

        public decimal Runid { get; set; }
        public decimal Levelid { get; set; }
        public decimal? Dimobj { get; set; }
        public decimal Flags { get; set; }
        public decimal Tblobj { get; set; }
        public byte[] Columnlist { get; set; }
        public string Levelname { get; set; }

        public virtual MviewAdvLog Run { get; set; }
        public virtual ICollection<MviewAdvRollup> MviewAdvRollupMviewAdvLevelNavigations { get; set; }
        public virtual ICollection<MviewAdvRollup> MviewAdvRollupMviewAdvLevels { get; set; }
    }
}
