using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseDemandform
    {
        public DatabaseDemandform()
        {
            DatabaseWritedemandforms = new HashSet<DatabaseWritedemandform>();
        }

        public string Id { get; set; }
        public string Goodsname { get; set; }
        public string Type { get; set; }
        public decimal Num { get; set; }

        public virtual ICollection<DatabaseWritedemandform> DatabaseWritedemandforms { get; set; }
    }
}
