using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseDonor
    {
        public DatabaseDonor()
        {
            DatabaseDonatetounits = new HashSet<DatabaseDonatetounit>();
            DatabaseDonorpurchases = new HashSet<DatabaseDonorpurchase>();
        }

        public string Name { get; set; }
        public string Id { get; set; }

        public virtual ICollection<DatabaseDonatetounit> DatabaseDonatetounits { get; set; }
        public virtual ICollection<DatabaseDonorpurchase> DatabaseDonorpurchases { get; set; }
    }
}
