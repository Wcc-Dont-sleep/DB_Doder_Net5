using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseTransport
    {
        public string Courierid { get; set; }
        public string Goodsid { get; set; }
        public string Startaddress { get; set; }
        public string Destination { get; set; }
        public string State { get; set; }
        public string Location { get; set; }

        public virtual DatabaseCourier Courier { get; set; }
        public virtual DatabaseGood Goods { get; set; }
    }
}
