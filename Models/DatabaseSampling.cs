using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseSampling
    {
        public string Id { get; set; }
        public DateTime Samplingtime { get; set; }
        public DateTime Detectiontime { get; set; }
        public string Institutionname { get; set; }

        public virtual DatabasePerson IdNavigation { get; set; }
        public virtual DatabaseTestinginstitution InstitutionnameNavigation { get; set; }
    }
}
