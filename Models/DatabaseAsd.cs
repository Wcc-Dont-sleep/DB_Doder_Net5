using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseAsd
    {
        public string Id { get; set; }
        public DateTime Signindate { get; set; }
        public DateTime? Signoutdate { get; set; }
        public string Isolationspotname { get; set; }

        public virtual DatabasePerson IdNavigation { get; set; }
        public virtual DatabaseIsolatedpoint IsolationspotnameNavigation { get; set; }
    }
}
