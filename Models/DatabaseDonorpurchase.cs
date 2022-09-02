using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseDonorpurchase
    {
        public string Goodsid { get; set; }
        public string Donorid { get; set; }
        public string Purchasetime { get; set; }

        public virtual DatabaseDonor Donor { get; set; }
        public virtual DatabaseGood Goods { get; set; }
    }
}
