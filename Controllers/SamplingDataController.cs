using DB_docker_net5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace DB_docker_net5.Controllers
{
    [Route("SamplingData")]
    [ApiController]
    public class SamplingDataController : Controller
    {
        private readonly ModelContext myContext;

        public SamplingDataController(ModelContext modelContext)
        {
            myContext = modelContext;
        }

        [HttpGet]
        public Dictionary<String, dynamic> getSamplingData()
        {
            List<Dictionary<string, dynamic>> samplingData_list = new();
            //List<Dictionary<string, dynamic>> isolatedPointsData_list = new();
            Dictionary<string, dynamic> data = new();

            var assign_list = myContext.DatabaseSamplings;
            foreach (var assign in assign_list)
            {

                Dictionary<string, dynamic> assignmentData = new();
                assignmentData.Add("personId", assign.Id);
                assignmentData.Add("name", assign.Name);
                assignmentData.Add("gender", assign.Gender);
                assignmentData.Add("phoneNumber", assign.Phonenumber);
                assignmentData.Add("testResult", assign.Testresult);
                assignmentData.Add("place", assign.Institutionname);
                assignmentData.Add("sampleTime", assign.Detectiontime);
                assignmentData.Add("IDcard", assign.Idcard);


                samplingData_list.Add(assignmentData);
            }
            data.Add("samplingData", samplingData_list);

      Result res = new Result(20000, "success", data);

            return res.Info;
        }

        [HttpDelete]
        public Dictionary<string,dynamic> deleteSamplingData([FromBody] dynamic postdata)
        {
            Result res = new Result();
            string rec = postdata.GetProperty("ID").ToString();
            DatabaseSampling record=myContext.DatabaseSamplings.Single(x=>x.Id==rec);
            myContext.DatabaseSamplings.Remove(record);
            myContext.SaveChanges();
            return res.Info;
        }

        [HttpPost]
        public Dictionary<string,dynamic> postSamplingData([FromBody] dynamic postdata)
        {
            Result res = new Result();

            string personId = postdata.GetProperty("personId").ToString();
            string name=postdata.GetProperty("name").ToString();
            string gender=postdata.GetProperty("gender").ToString();
            string IDcard=postdata.GetProperty("IDcard").ToString();
            string place = postdata.GetProperty("place").ToString();
            string sampleTime = postdata.GetProperty("sampleTime").ToString();
            string testResult = postdata.GetProperty("testResult").ToString();
            string phoneNumber = postdata.GetProperty("phoneNumber").ToString();

            string address = myContext.DatabasePerson.Single(a => a.Id == personId).Address;

            DatabaseSampling newsample = new DatabaseSampling();
            newsample.Id = personId;
            newsample.Gender = decimal.Parse(gender);
            newsample.Name = name;
            newsample.Idcard = IDcard;
            newsample.Phonenumber=phoneNumber;
            newsample.Institutionname = place;
            newsample.Testresult = testResult;
            newsample.Detectiontime = sampleTime;
            newsample.Place = address;

            myContext.DatabaseSamplings.Add(newsample);
            myContext.SaveChanges();
           
            return res.Info;
        }

        [HttpPut]
        public Dictionary<string,dynamic> putSamplingData([FromBody] dynamic postdata)
        {
            Result res = new Result();

            string personId = postdata.GetProperty("personId").ToString();
            string name = postdata.GetProperty("name").ToString();
            //stringnder = postdata.GetProperty("gender").ToString();
            string IDcard = postdata.GetProperty("IDcard").ToString();
            string place = postdata.GetProperty("place").ToString();
            string sampleTime = postdata.GetProperty("sampleTime").ToString();
            string testResult = postdata.GetProperty("testResult").ToString();
            string phoneNumber = postdata.GetProperty("phoneNumber").ToString();

            DatabaseSampling newsample = myContext.DatabaseSamplings.Single(x => x.Id == personId);
            myContext.DatabaseSamplings.Remove(newsample);
            myContext.SaveChanges();

            newsample.Id = personId;
            //newsample.gender = gender;
            newsample.Name = name;
            newsample.Idcard = IDcard;
            newsample.Phonenumber = phoneNumber;
            newsample.Place = place;
            newsample.Testresult = testResult;
            newsample.Detectiontime = sampleTime;

            myContext.DatabaseSamplings.Add(newsample);
            myContext.SaveChanges();

            return res.Info;
        }

    }
}
