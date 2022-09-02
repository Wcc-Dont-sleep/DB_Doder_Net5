using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class AqKeyShardMap
    {
        public decimal Queue { get; set; }
        public string Key { get; set; }
        public decimal Shard { get; set; }
        public decimal DelayShard { get; set; }
    }
}
