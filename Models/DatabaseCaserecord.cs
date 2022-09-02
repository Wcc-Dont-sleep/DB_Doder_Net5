using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseCaserecord
    {
        public string Id { get; set; }
        public string Source { get; set; }
        public DateTime Discoverdate { get; set; }
        public string Casetype { get; set; }
        public string Location { get; set; }

        public virtual DatabasePerson IdNavigation { get; set; }
    }
}
