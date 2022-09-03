using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseIsolatedpoint
    {
        public DatabaseIsolatedpoint()
        {
            DatabaseIsolationassigns = new HashSet<DatabaseIsolationassign>();
        }

        public string Name { get; set; }
        public string Reigon { get; set; }
        public int Capacity { get; set; }
        public int Num { get; set; }
        public int Cost { get; set; }
        public string Resourcetype { get; set; }

        public virtual ICollection<DatabaseIsolationassign> DatabaseIsolationassigns { get; set; }
    }
}
