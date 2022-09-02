using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseDonatetounit
    {
        public string Donorid { get; set; }
        public string Epidemiccontrolunitsid { get; set; }
        public string Donatetime { get; set; }
        public string Goodsid { get; set; }

        public virtual DatabaseDonor Donor { get; set; }
        public virtual DatabaseEpidemiccontrolunit Epidemiccontrolunits { get; set; }
        public virtual DatabaseGood Goods { get; set; }
    }
}
