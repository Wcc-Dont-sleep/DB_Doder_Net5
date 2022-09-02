using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseTestinfo
    {
        public string Id { get; set; }
        public string Samtime { get; set; }
        public string Testtime { get; set; }
        public string Testinsname { get; set; }

        public virtual DatabasePerson IdNavigation { get; set; }
        public virtual DatabaseTestinginstitution TestinsnameNavigation { get; set; }
    }
}
