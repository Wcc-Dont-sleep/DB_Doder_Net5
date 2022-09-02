using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class Ol
    {
        public string OlName { get; set; }
        public string SqlText { get; set; }
        public decimal? Textlen { get; set; }
        public Guid? Signature { get; set; }
        public decimal? HashValue { get; set; }
        public decimal? HashValue2 { get; set; }
        public string Category { get; set; }
        public string Version { get; set; }
        public string Creator { get; set; }
        public DateTime? Timestamp { get; set; }
        public decimal? Flags { get; set; }
        public decimal? Hintcount { get; set; }
        public decimal? Spare1 { get; set; }
        public string Spare2 { get; set; }
    }
}
