using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class SchedulerJobArgsTbl
    {
        public string Owner { get; set; }
        public string JobName { get; set; }
        public string ArgumentName { get; set; }
        public decimal? ArgumentPosition { get; set; }
        public string ArgumentType { get; set; }
        public string Value { get; set; }
        public string OutArgument { get; set; }
    }
}
