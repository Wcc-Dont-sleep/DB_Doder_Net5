using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class MviewAdvParameter
    {
        public string ParameterName { get; set; }
        public decimal ParameterType { get; set; }
        public string StringValue { get; set; }
        public DateTime? DateValue { get; set; }
        public decimal? NumericalValue { get; set; }
    }
}
