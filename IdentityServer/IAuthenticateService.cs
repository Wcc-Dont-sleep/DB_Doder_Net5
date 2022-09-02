using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB_docker_net5.Models;

namespace DB_docker_net5.IdentityServer
{
    public interface IAuthenticateService
    {
        public bool IsAuthenticated(User request, out string token)
        {
            throw new NotImplementedException();
        }
    }
}
