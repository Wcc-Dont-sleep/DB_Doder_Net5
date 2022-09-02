using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class MviewAdvLog
    {
        public MviewAdvLog()
        {
            MviewAdvAjgs = new HashSet<MviewAdvAjg>();
            MviewAdvCliques = new HashSet<MviewAdvClique>();
            MviewAdvEligibles = new HashSet<MviewAdvEligible>();
            MviewAdvInfos = new HashSet<MviewAdvInfo>();
            MviewAdvJournals = new HashSet<MviewAdvJournal>();
            MviewAdvLevels = new HashSet<MviewAdvLevel>();
            MviewAdvOutputs = new HashSet<MviewAdvOutput>();
            MviewAdvRollups = new HashSet<MviewAdvRollup>();
        }

        public decimal Runid { get; set; }
        public decimal? Filterid { get; set; }
        public DateTime? RunBegin { get; set; }
        public DateTime? RunEnd { get; set; }
        public decimal? RunType { get; set; }
        public string Uname { get; set; }
        public decimal Status { get; set; }
        public string Message { get; set; }
        public decimal? Completed { get; set; }
        public decimal? Total { get; set; }
        public string ErrorCode { get; set; }

        public virtual ICollection<MviewAdvAjg> MviewAdvAjgs { get; set; }
        public virtual ICollection<MviewAdvClique> MviewAdvCliques { get; set; }
        public virtual ICollection<MviewAdvEligible> MviewAdvEligibles { get; set; }
        public virtual ICollection<MviewAdvInfo> MviewAdvInfos { get; set; }
        public virtual ICollection<MviewAdvJournal> MviewAdvJournals { get; set; }
        public virtual ICollection<MviewAdvLevel> MviewAdvLevels { get; set; }
        public virtual ICollection<MviewAdvOutput> MviewAdvOutputs { get; set; }
        public virtual ICollection<MviewAdvRollup> MviewAdvRollups { get; set; }
    }
}
