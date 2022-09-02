using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseGood
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public int? Price { get; set; }
        public decimal? Num { get; set; }
        public string Dop { get; set; }
        public int? Exp { get; set; }

        public virtual DatabaseDonatetounit DatabaseDonatetounit { get; set; }
        public virtual DatabaseDonorpurchase DatabaseDonorpurchase { get; set; }
        public virtual DatabaseTransport DatabaseTransport { get; set; }
        public virtual DatabaseUnitspurchase DatabaseUnitspurchase { get; set; }
    }
}
