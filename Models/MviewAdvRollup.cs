using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class MviewAdvRollup
    {
        public decimal Runid { get; set; }
        public decimal Clevelid { get; set; }
        public decimal Plevelid { get; set; }
        public decimal Flags { get; set; }

        public virtual MviewAdvLevel MviewAdvLevel { get; set; }
        public virtual MviewAdvLevel MviewAdvLevelNavigation { get; set; }
        public virtual MviewAdvLog Run { get; set; }
    }
}
