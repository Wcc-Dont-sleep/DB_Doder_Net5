using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseDemandform
    {
        public string Id { get; set; }
        public string Goodsname { get; set; }
        public string Type { get; set; }
        public decimal Num { get; set; }
        public byte? Isallocated { get; set; }
    }
}
