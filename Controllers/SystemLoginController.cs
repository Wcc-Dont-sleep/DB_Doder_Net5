using DB_docker_net5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB_docker_net5.Controllers
{
    //补上两行路由代码
    [ApiController]
    [Route("user")]

    public class SystemLoginController : ControllerBase
    {
        //补上模型上下文对象
        private readonly ModelContext myContext;

        //补上默认对象传入
        public SystemLoginController(ModelContext modelContext)
        {
            myContext = modelContext;
        }
        //从此开始写代码
        [HttpGet]
        public void GetUserInfo(string token)
        {

        }

    }
}