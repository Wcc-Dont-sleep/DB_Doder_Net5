﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class LogmnrGtTabInclude
    {
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string PdbName { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public string Spare3 { get; set; }
    }
}
