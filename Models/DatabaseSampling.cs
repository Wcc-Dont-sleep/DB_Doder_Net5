using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseSampling
    {
        public string Id { get; set; }
        public string Detectiontime { get; set; }
        public string Institutionname { get; set; }
        public string Name { get; set; }
        public decimal? Gender { get; set; }
        public string Idcard { get; set; }
        public string Place { get; set; }
        public string Testresult { get; set; }
        public string Phonenumber { get; set; }

        public virtual DatabasePerson IdNavigation { get; set; }
        public virtual DatabaseTestinginstitution InstitutionnameNavigation { get; set; }
    }
}
