using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class MviewEvaluation
    {
        public decimal Runid { get; set; }
        public string MviewOwner { get; set; }
        public string MviewName { get; set; }
        public decimal Rank { get; set; }
        public decimal? StorageInBytes { get; set; }
        public decimal? Frequency { get; set; }
        public decimal? CumulativeBenefit { get; set; }
        public decimal BenefitToCostRatio { get; set; }
    }
}
