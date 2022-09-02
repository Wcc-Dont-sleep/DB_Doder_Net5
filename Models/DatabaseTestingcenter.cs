using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseTestingcenter
    {
        public DatabaseTestingcenter()
        {
            DatabaseTestingcenterassignments = new HashSet<DatabaseTestingcenterassignment>();
        }

        public string Name { get; set; }
        public string Location { get; set; }
        public int Maxnum { get; set; }
        public string Resourcetype { get; set; }

        public virtual DatabaseRiskingarea LocationNavigation { get; set; }
        public virtual ICollection<DatabaseTestingcenterassignment> DatabaseTestingcenterassignments { get; set; }
    }
}
