using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrProp
    {
        public string Value { get; set; }
        public string Comment { get; set; }
        public string Name { get; set; }
        public decimal? LogmnrUid { get; set; }
        public decimal? LogmnrFlags { get; set; }
    }
}
