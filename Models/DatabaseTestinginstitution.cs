using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseTestinginstitution
    {
        public DatabaseTestinginstitution()
        {
            DatabaseSamplings = new HashSet<DatabaseSampling>();
            DatabaseTestinfos = new HashSet<DatabaseTestinfo>();
        }

        public string Institutionname { get; set; }
        public string District { get; set; }
        public decimal Maxnumber { get; set; }
        public string Resourcetype { get; set; }

        public virtual DatabaseRiskingarea DistrictNavigation { get; set; }
        public virtual ICollection<DatabaseSampling> DatabaseSamplings { get; set; }
        public virtual ICollection<DatabaseTestinfo> DatabaseTestinfos { get; set; }
    }
}
