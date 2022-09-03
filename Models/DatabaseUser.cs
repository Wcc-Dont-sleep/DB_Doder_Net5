using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseUser
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Loginstatus { get; set; }
        public string Username { get; set; }

        public virtual DatabasePerson IdNavigation { get; set; }
    }
}
