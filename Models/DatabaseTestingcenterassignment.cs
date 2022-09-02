using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseTestingcenterassignment
    {
        public string Id { get; set; }
        public DateTime Testingdate { get; set; }
        public string Name { get; set; }

        public virtual DatabasePerson IdNavigation { get; set; }
        public virtual DatabaseTestingcenter NameNavigation { get; set; }
    }
}
