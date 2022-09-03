using Microsoft.AspNetCore.Mvc;
using DB_docker_net5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Newtonsoft.Json;
using RestSharp;
using System.Json;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace DB_docker_net5.Controllers
{
    [ApiController]
    [Route("manage")]
    public class manageController : ControllerBase
    {
        private readonly ModelContext myContext; // 创建一个模型上下文对象
       
        // 构造函数，在每次调用该Controller中的api函数时，都会创建一个context对象用于操作数据库
        public manageController(ModelContext modelContext)
        {
            myContext = modelContext;
        }

        [HttpPost]
        public Dictionary<string, dynamic> addmanage(dynamic postdata)
        {
           
            JsonElement.ArrayEnumerator JsonArray = postdata.GetProperty("personIDs").EnumerateArray();
            string UnitID = postdata.GetProperty("unitID").ToString();
            var jsonArray = JsonArray.ToArray();

            int code = 20000;
            var ep = myContext.DatabaseEpidemiccontrolunits.Single(b => b.Id == UnitID);
            for (int i = 0; i < jsonArray.Count(); i++)
            {
                bool isthere = myContext.DatabaseManages.Any(a => a.Personid == jsonArray[i].ToString());
                if (isthere == true)
                {
                    break;
                }
                DatabaseManage mana = new DatabaseManage();
                mana.Personid = jsonArray[i].ToString();
                var person = myContext.DatabasePerson.Single(b => b.Id == jsonArray[i].ToString());
                mana.Personname = person.Name;
                mana.Epidemiccontrolunitsid = UnitID;
                mana.Epname = ep.Name;
                myContext.DatabaseManages.Add(mana);
                myContext.SaveChanges();
            }
            Result info = new Result(code);
            return info.Info;
        }
        [HttpGet]
        public Dictionary<string, dynamic> getmanage()
        {
            List<Dictionary<string, dynamic>> data_list = new();
            //List<Dictionary<string, dynamic>> isolatedPointsData_list = new();
            Dictionary<string, dynamic> data = new();

            var list6 = myContext.DatabaseManages;
            foreach (var list in list6)
            {
                Dictionary<string, dynamic> assignmentData = new();
                
                assignmentData.Add("personId", list.Personid);
                assignmentData.Add("personName", list.Personname);
                assignmentData.Add("UnitId",list.Epidemiccontrolunitsid);
                assignmentData.Add("UnitName", list.Epname);

                data_list.Add(assignmentData);
            }
            data.Add("manageRecord", data_list);

            Result info = new Result(20000, "success", data);
            return info.Info;
        }
        [HttpDelete]
        public Dictionary<string, dynamic> deletemanage(dynamic postdata)
        {
            string ID = postdata.GetProperty("personId").ToString();

            int code = 20000;
            string mes = "success";
            var isthere = myContext.DatabaseManages.Any(a => a.Personid == ID);
            if (isthere == true)
            {
                var manage = myContext.DatabaseManages.Single(a => a.Personid == ID);
                myContext.DatabaseManages.Remove(manage);
                myContext.SaveChanges();
            }
            Result info = new Result(code, mes);
            return info.Info;
        }
        
    }
}
