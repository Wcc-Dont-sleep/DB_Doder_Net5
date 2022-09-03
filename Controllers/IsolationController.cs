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
            List<Dictionary<string, dynamic>> isolateData_list = new();
            Dictionary<string, dynamic> data = new();

            var assign_list =  myContext.DatabaseCaserecords;
            foreach(var assign in assign_list)
            {
                var person = myContext.DatabasePerson.Single(a => a.Id == assign.Id);
                Dictionary<string, dynamic> assignmentData = new();
                assignmentData.Add("id", person.Id);
                assignmentData.Add("name", person.Name);
                assignmentData.Add("gender", person.Gender);
                assignmentData.Add("phoneNumber", person.Phonenumber);
                assignmentData.Add("address", person.Address);
                assignmentData.Add("caseType", assign.Casetype);

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

            var isolate_list = myContext.DatabaseIsolationassigns;
            foreach(var isolate in isolate_list)
            {
                var person = myContext.DatabasePerson.Single(a => a.Id == isolate.Id);
                
                Dictionary<string, dynamic> isolatedata = new();

                isolatedata.Add("id", person.Id);
                isolatedata.Add("name", person.Name);
                isolatedata.Add("gender", person.Gender);
                isolatedata.Add("phoneNumber", person.Phonenumber);
                isolatedata.Add("address", person.Address);
                isolatedata.Add("signindate", isolate.Signindate);
                isolatedata.Add("signoutdate", isolate.Signoutdate);

                isolateData_list.Add(isolatedata);
            }
                   
            data.Add("assignmentData", assignmentData_list);
            data.Add("isolatedPointsData", isolatedPointsData_list);
            data.Add("data1", isolateData_list);

            Result res = new(20000, "success", data);
            return res.Info;
        }

        [HttpPost("isolatedPointsData")]
        public Dictionary<string, dynamic> UpdatePointInfo(dynamic postdata)
        {
            string ID = postdata.GetProperty("id").ToString();
            string Name = postdata.GetProperty("name").ToString();

            bool isSuccess = myContext.DatabaseIsolatedpoints.Any(a => a.Name == Name)&& myContext.DatabaseCaserecords.Any(a => a.Id == ID);

            if (isSuccess)
            {
                //隔离点数量加1
                var point = myContext.DatabaseIsolatedpoints.Single(a => a.Name == Name);
                point.Num++;
                myContext.SaveChanges();

                DatabaseIsolationassign assign = new();
                assign.Id = ID;
                assign.Signoutdate = DateTime.Now.AddDays(7);
                assign.Signindate = DateTime.Now;
                assign.Isolationspotname = Name;

                //新增分配记录
                myContext.DatabaseIsolationassigns.Add(assign);
                myContext.SaveChanges();

                //删除病历记录
                myContext.DatabaseCaserecords.Remove(myContext.DatabaseCaserecords.Single(a => a.Id == ID));
                myContext.SaveChanges();

                Result res = new();
                return res.Info;
            }
            else
            {
                Result res = new(0, "用户ID或隔离点名字不存在");
                return res.Info;
            }

        }
 
    }
}
