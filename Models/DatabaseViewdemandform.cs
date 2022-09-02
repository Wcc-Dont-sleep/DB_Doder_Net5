using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseViewdemandform
    {
        public string Epidemiccontrolunitsid { get; set; }
        public string Demandformid { get; set; }

        public virtual DatabaseDemandform Demandform { get; set; }
        public virtual DatabaseEpidemiccontrolunit Epidemiccontrolunits { get; set; }
    }
}
