using Microsoft.AspNetCore.Mvc;
using DB_docker_net5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.EntityFrameworkCore;

namespace DB_docker_net5.Controllers
{
    [ApiController]
    [Route("unManagePersonData")]
    public class ManageInfoController : ControllerBase
    {
        private readonly ModelContext myContext; // 创建一个模型上下文对象

        // 构造函数，在每次调用该Controller中的api函数时，都会创建一个context对象用于操作数据库
        public ManageInfoController(ModelContext modelContext)
        {
            myContext = modelContext;
        }
        [HttpGet]
        public Dictionary<string, dynamic> unmanageperson()
        {

            List<Dictionary<string, dynamic>> data_list = new();
            //List<Dictionary<string, dynamic>> isolatedPointsData_list = new();
            Dictionary<string, dynamic> data = new();

            int code = 20000;
            string mes = "success";
   
            var listperson = myContext.DatabasePerson.ToList();
            var listmana = myContext.DatabaseManages.ToList();
            int num = listperson.Count > listmana.Count ? listperson.Count : listmana.Count;
            for (int i = 0; i < listperson.Count; i++)
            {
                for (int j = 0; j < listmana.Count; j++)
                {
                    if (listperson[i].Id == listmana[j].Personid)
                    {
                        listperson.RemoveAt(i);
                    }
                }
            }

            foreach (var person in listperson)
            {
                Dictionary<string, dynamic> assignmentData = new();

                assignmentData.Add("ID", person.Id);
                assignmentData.Add("name", person.Name);
                assignmentData.Add("age", person.Age);
                assignmentData.Add("phoneNumber", person.Phonenumber);

                data_list.Add(assignmentData);
            }

            data.Add("unManagedPersonData", data_list);
            Result info = new Result(code, mes, data);
            return info.Info;
        }
    }
}
