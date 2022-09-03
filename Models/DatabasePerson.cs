using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabasePerson
    {
        public DatabasePerson()
        {
            DatabaseManages = new HashSet<DatabaseManage>();
            DatabaseTestinfos = new HashSet<DatabaseTestinfo>();
            DatabaseTrajectories = new HashSet<DatabaseTrajectory>();
            DatabaseWritedemandforms = new HashSet<DatabaseWritedemandform>();
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }

        public virtual DatabaseRiskingarea AddressNavigation { get; set; }
        public virtual DatabaseCaserecord DatabaseCaserecord { get; set; }
        public virtual DatabaseIsolationassign DatabaseIsolationassign { get; set; }
        public virtual DatabaseSampling DatabaseSampling { get; set; }
        public virtual DatabaseStaff DatabaseStaff { get; set; }
        public virtual DatabaseTestingcenterassignment DatabaseTestingcenterassignment { get; set; }
        public virtual DatabaseUser DatabaseUser { get; set; }
        public virtual DatabaseVolunteer DatabaseVolunteer { get; set; }
        public virtual ICollection<DatabaseManage> DatabaseManages { get; set; }
        public virtual ICollection<DatabaseTestinfo> DatabaseTestinfos { get; set; }
        public virtual ICollection<DatabaseTrajectory> DatabaseTrajectories { get; set; }
        public virtual ICollection<DatabaseWritedemandform> DatabaseWritedemandforms { get; set; }
    }
}
