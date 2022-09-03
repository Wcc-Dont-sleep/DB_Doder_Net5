using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseEpidemiccontrolunit
    {
        public DatabaseEpidemiccontrolunit()
        {
            DatabaseDonatetounits = new HashSet<DatabaseDonatetounit>();
            DatabaseManages = new HashSet<DatabaseManage>();
            DatabaseUnitspurchases = new HashSet<DatabaseUnitspurchase>();
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public string Citybelongs { get; set; }
        public string Districtbelongs { get; set; }
        public string Address { get; set; }
        public string Servicehotline { get; set; }
        public string Phonenumber { get; set; }

        public virtual ICollection<DatabaseDonatetounit> DatabaseDonatetounits { get; set; }
        public virtual ICollection<DatabaseManage> DatabaseManages { get; set; }
        public virtual ICollection<DatabaseUnitspurchase> DatabaseUnitspurchases { get; set; }
    }
}
