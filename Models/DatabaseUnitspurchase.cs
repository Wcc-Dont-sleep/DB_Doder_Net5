using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseUnitspurchase
    {
        public string Epidemiccontrolunitsid { get; set; }
        public string Goodsid { get; set; }
        public string Purchasetime { get; set; }

        public virtual DatabaseEpidemiccontrolunit Epidemiccontrolunits { get; set; }
        public virtual DatabaseGood Goods { get; set; }
    }
}
