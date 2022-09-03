using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseCourier
    {
        public DatabaseCourier()
        {
            DatabaseTransports = new HashSet<DatabaseTransport>();
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public string Workaddress { get; set; }
        public string Company { get; set; }
        public string Phonenumber { get; set; }

        public virtual ICollection<DatabaseTransport> DatabaseTransports { get; set; }
    }
}
