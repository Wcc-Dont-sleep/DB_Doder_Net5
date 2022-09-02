using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB_docker_net5.Models;
using Microsoft.EntityFrameworkCore;

namespace DB_docker_net5.Controllers
{
    [ApiController]
    [Route("isolationData")]
    public class IsolationController : ControllerBase
    {
        
        private readonly ModelContext myContext; // 创建一个模型上下文对象

        
        public IsolationController(ModelContext modelContext)
        {
            myContext = modelContext;
        }

        [HttpGet]
        public Dictionary<string,dynamic> getIsolationInfo()
        {
            List<Dictionary<string, dynamic>> assignmentData_list = new();
            List<Dictionary<string, dynamic>> isolatedPointsData_list = new();
            Dictionary<string, dynamic> data = new();

            var assign_list =  myContext.DatabaseIsolationassigns;
            foreach(var assign in assign_list)
            {
                var person = myContext.DatabasePerson.Single(a => a.Id == assign.Id);
                Dictionary<string, dynamic> assignmentData = new();
                assignmentData.Add("id", person.Id);
                assignmentData.Add("name", person.Name);
                assignmentData.Add("gender", person.Gender);
                assignmentData.Add("phonenum", person.Phonenumber);
                assignmentData.Add("address", person.Address);
                assignmentData.Add("signInDate", assign.Signindate);
                assignmentData.Add("signOutDate", assign.Signoutdate);

                assignmentData_list.Add(assignmentData);
            }
            var point_list = myContext.DatabaseIsolatedpoints;
            foreach( var point in point_list)
            {
                Dictionary<string, dynamic> isolatedPointsData = new();
                isolatedPointsData.Add("name", point.Name);
                isolatedPointsData.Add("region", point.Reigon);
                isolatedPointsData.Add("capacity", point.Capacity);
                isolatedPointsData.Add("num", point.Num);
                isolatedPointsData.Add("cost", point.Cost);

                isolatedPointsData_list.Add(isolatedPointsData);
            }
                   
            data.Add("assignmentData", assignmentData_list);
            data.Add("isolatedPointsData", isolatedPointsData_list);

            Result res = new(20000, "success", data);
            return res.Info;
        }

        [HttpPost("isolatedPointsData")]
        public Dictionary<string, dynamic> UpdatePointInfo(dynamic postdata)
        {
            string Name = postdata.GetProperty("name").ToString();
            bool isSuccess = myContext.DatabaseIsolatedpoints.Any(a => a.Name == Name);

            if (isSuccess)
            {
                var point = myContext.DatabaseIsolatedpoints.Single(a => a.Name == Name);
                point.Num++;
                myContext.SaveChanges();
                Result res = new();
                return res.Info;
            }
            else
            {
                Result res = new(0, "隔离点名字不存在");
                return res.Info;
            }

        }
        
        [HttpPost("assignmentData")]
        public Dictionary<string, dynamic> assignmentData(dynamic postdata)
        {
            string ID = postdata.GetProperty("id").ToString();
           
            bool isSuccess = myContext.DatabaseIsolationassigns.Any(a => a.Id == ID);
            if (isSuccess)
            {
                var isoAssign = myContext.DatabaseIsolationassigns.Single(a => a.Id == ID);
                myContext.DatabaseIsolationassigns.Remove(isoAssign);

                myContext.SaveChanges();
                Result res = new();
                return res.Info;
            }
            else
            {
                Result res = new(0, "用户ID不存在");
                return res.Info;
            }
        }
        
    }
}
