using DB_docker_net5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB_docker_net5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ModelContext myContext; // 创建一个模型上下文对象

        
        public LoginController(ModelContext modelContext)
        {
            myContext = modelContext;
        }

        //这里“”内的东西是对于同种post（或者get、put等方法）进行命名，保证不会重复，命名为函数名即可
        [HttpPost("Test")]

        public DatabasePerson Test()
        {
            //调用model文件夹里面的数据库模型
            DatabasePerson person = new DatabasePerson();
            string ID = "2054077";
            /*
            person.Name = "'wrx404'";
            person.Gender = "1";
            person.Age = "20";
            person.Address = "ShangHai";
            person.Password = "";
            person.Loginstatus = "";
            person.Phonenumber = "";
            */
            //sql添加数据方法，每次传入为数据的某个表，调用完后必须保存更改，即调用SavaChanges方法
            //myContext.DatabasePerson.Add(person);
            person = myContext.DatabasePerson.Single(b => b.Id == ID);
            myContext.SaveChanges();
            return person;
        }

    }
}
