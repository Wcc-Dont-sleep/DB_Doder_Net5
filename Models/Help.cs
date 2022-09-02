using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class Help
    {
        public string Topic { get; set; }
        public decimal Seq { get; set; }
        public string Info { get; set; }
    }
}
