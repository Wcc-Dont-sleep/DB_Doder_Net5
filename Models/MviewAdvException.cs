using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class MviewAdvException
    {
        public decimal? Runid { get; set; }
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string DimensionName { get; set; }
        public string Relationship { get; set; }
        public string BadRowid { get; set; }

        public virtual MviewAdvLog Run { get; set; }
    }
}
