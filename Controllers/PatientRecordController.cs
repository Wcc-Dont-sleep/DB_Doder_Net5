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
    [Route("PatientRecord")]
    [ApiController]
    public class PatientRecordController : Controller
    {
        private readonly ModelContext myContext;

        public PatientRecordController(ModelContext modelContext)
        {
            myContext = modelContext;
        }

        [HttpPost]
        public Dictionary<string,dynamic> patientRecord([FromBody] dynamic postdata)
        {
            Result res = new Result();
            string ID = postdata.GetProperty("ID").ToString();
            string DetectionTime=postdata.GetProperty("DetectionTime").ToString();
            string SamplingResult = postdata.GetProperty("SamplingResult").ToString();
            var isExist = myContext.DatabaseCaserecords.Any(a => a.Id == ID);
            if (isExist)
            {
                Result rest = new Result(50018, "该用户已经存在病历记录，请勿重复插入");
                return rest.Info;

            }
            DatabaseCaserecord newcase = new DatabaseCaserecord();
            newcase.Discoverdate = DetectionTime;
            newcase.Id = ID;
            newcase.Casetype = SamplingResult;
            myContext.DatabaseCaserecords.Add(newcase);
            myContext.SaveChanges();


            return res.Info;
        }
    }
}
