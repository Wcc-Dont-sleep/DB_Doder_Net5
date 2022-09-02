using System;
using System.Collections.Generic;

#nullable disable

namespace DB_docker_net5.Models
{
    public partial class AqInternetAgentPriv
    {
        public string AgentName { get; set; }
        public string DbUsername { get; set; }

        public virtual AqInternetAgent AgentNameNavigation { get; set; }
    }
}
