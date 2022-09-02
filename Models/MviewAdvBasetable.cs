using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class MviewAdvBasetable
    {
        public decimal Collectionid { get; set; }
        public decimal Queryid { get; set; }
        public string Owner { get; set; }
        public string TableName { get; set; }
        public decimal? TableType { get; set; }

        public virtual MviewAdvWorkload Query { get; set; }
    }
}
