using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseWritedemandform
    {
        public string Personid { get; set; }
        public string Writetime { get; set; }
        public string Demandformid { get; set; }

        public virtual DatabaseDemandform Demandform { get; set; }
        public virtual DatabasePerson Person { get; set; }
    }
}
