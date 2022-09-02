using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseVolunteer
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public string Servedate { get; set; }
        public string Origin { get; set; }
        public string Volunteertype { get; set; }

        public virtual DatabasePerson IdNavigation { get; set; }
    }
}
