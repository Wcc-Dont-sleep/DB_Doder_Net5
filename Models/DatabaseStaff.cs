using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseStaff
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string RiskGarde { get; set; }

        public virtual DatabasePerson IdNavigation { get; set; }
    }
}
