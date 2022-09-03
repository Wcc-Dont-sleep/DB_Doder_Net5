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
    [Route("transportData")]
    [ApiController]
    public class transportDataController : Controller
    {
        private readonly ModelContext myContext;

        public transportDataController(ModelContext modelContext)
        {
            myContext = modelContext;
        }

        [HttpGet]
        public Dictionary<string, dynamic> Get()
        {
            List<Dictionary<string, dynamic>> samplingData_list = new();
            //List<Dictionary<string, dynamic>> isolatedPointsData_list = new();
            Dictionary<string, dynamic> data = new();

            var trans = myContext.DatabaseTransports;
            foreach (var assign in trans)
            {
                Dictionary<string, dynamic> assignmentData = new();
                var carry = myContext.DatabaseCouriers.Single(a => a.Id == assign.Courierid);
                var good = myContext.DatabaseGoods.Single(b => b.Id == assign.Goodsid);
                assignmentData.Add("courierID", assign.Courierid);
                assignmentData.Add("courierName", carry.Name);
                assignmentData.Add("courierCompany", carry.Company);
                assignmentData.Add("courierPhone", carry.Phonenumber);
                assignmentData.Add("state", assign.State);
                assignmentData.Add("currentLocation", assign.Location);
                assignmentData.Add("destination", assign.Destination);
                assignmentData.Add("departure", assign.Startaddress);
                assignmentData.Add("materialName",good.Name);
                assignmentData.Add("materialType", good.Type);
                assignmentData.Add("materialID", assign.Goodsid);
                assignmentData.Add("materialNum", good.Num);

                samplingData_list.Add(assignmentData);
            }
            data.Add("transportData", samplingData_list);

            Result res = new Result(20000, "success", data);

            return res.Info;
        }

        [HttpPost]
        public Dictionary<string,dynamic> addTransportData([FromBody] dynamic postdata)
        {
            Result res = new Result();

            Dictionary <string,dynamic> data = new Dictionary<string,dynamic>();
            string materialID = postdata.GetProperty("materialID").ToString();
            string courierID = postdata.GetProperty("courierID").ToString();
            string state=postdata.GetProperty("state").ToString();
            string depature = postdata.GetProperty("departure").ToString();
            string destination=postdata.GetProperty("destination").ToString();
            string currentLocation = postdata.GetProperty("currentLocation").ToString();

            var newtrans = new DatabaseTransport();
            newtrans.Destination = destination;
            newtrans.Startaddress = depature;
            newtrans.State = state;
            newtrans.Courierid=courierID;
            newtrans.Location = currentLocation;
            newtrans.Goodsid = materialID;
            myContext.DatabaseTransports.Add(newtrans);
            myContext.SaveChanges();


            return res.Info;
        }
    }
    
}
