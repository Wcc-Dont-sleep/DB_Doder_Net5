using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseManage
    {
        public string Epidemiccontrolunitsid { get; set; }
        public string Personid { get; set; }
        public string Epname { get; set; }
        public string Personname { get; set; }

        public virtual DatabaseEpidemiccontrolunit Epidemiccontrolunits { get; set; }
        public virtual DatabasePerson Person { get; set; }
    }
}
