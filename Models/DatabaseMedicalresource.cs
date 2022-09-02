using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class DatabaseMedicalresource
    {
        public string Medicalresourcetype { get; set; }
        public int Medicalresourcenumber { get; set; }
        public string Area { get; set; }

        public virtual DatabaseRiskingarea AreaNavigation { get; set; }
    }
}
