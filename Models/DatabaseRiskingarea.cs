using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseRiskingarea
    {
        public DatabaseRiskingarea()
        {
            DatabaseMedicalresources = new HashSet<DatabaseMedicalresource>();
            DatabasePeople = new HashSet<DatabasePerson>();
            DatabaseTestingcenters = new HashSet<DatabaseTestingcenter>();
            DatabaseTestinginstitutions = new HashSet<DatabaseTestinginstitution>();
            DatabaseTrajectories = new HashSet<DatabaseTrajectory>();
        }

        public string Name { get; set; }
        public string Riskinglevel { get; set; }

        public virtual ICollection<DatabaseMedicalresource> DatabaseMedicalresources { get; set; }
        public virtual ICollection<DatabasePerson> DatabasePeople { get; set; }
        public virtual ICollection<DatabaseTestingcenter> DatabaseTestingcenters { get; set; }
        public virtual ICollection<DatabaseTestinginstitution> DatabaseTestinginstitutions { get; set; }
        public virtual ICollection<DatabaseTrajectory> DatabaseTrajectories { get; set; }
    }
}
