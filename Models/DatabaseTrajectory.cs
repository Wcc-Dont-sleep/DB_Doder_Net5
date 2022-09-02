using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseTrajectory
    {
        public string Id { get; set; }
        public string Time { get; set; }
        public string Spot { get; set; }

        public virtual DatabasePerson IdNavigation { get; set; }
        public virtual DatabaseRiskingarea SpotNavigation { get; set; }
    }
}
