using DB_docker_net5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace DB_docker_net5.Controllers
{
    [ApiController]
    [Route("volunteerApplication")]
    public class VolunteerController : Controller//志愿申请
    {
        private readonly ModelContext myContext; // 创建一个模型上下文对象

        // 构造函数，在每次调用该Controller中的api函数时，都会创建一个context对象用于操作数据库
        public VolunteerController(ModelContext modelContext)
        {
            myContext = modelContext;
        }
        [HttpPost()]
        //[Authorize]
        public Dictionary<string, dynamic> VolunteerApply(dynamic request)//志愿申请填写
        {
            string personID = request.GetProperty("ID").ToString();
            bool num1 = myContext.DatabasePerson.Any(b => b.Id == personID);//判断是否有这个人
            if (num1 == false)
            {
                DatabasePerson person = new DatabasePerson();//插入Person

                person.Id = request.GetProperty("ID").ToString();
                person.Name = request.GetProperty("name").ToString();

                person.Phonenumber = "111";
                person.Gender = "1";
                myContext.DatabasePerson.Add(person);
                myContext.SaveChanges();
            }
           
                DatabaseVolunteer volunteer = new DatabaseVolunteer();//插入数据
            string ID = request.GetProperty("ID").ToString();
            bool num2 = myContext.DatabaseVolunteers.Any(b => b.Id == ID);//判断是否有这个人
            if (num2 ==true)
            {
                Result res = new Result(0, "该志愿者已经申请过！");

                return res.Info;

            }
            else {
                volunteer.Id = request.GetProperty("ID").ToString();
                volunteer.Location = request.GetProperty("volunteerLocation").ToString();
                volunteer.Servedate = request.GetProperty("date1").ToString();
                volunteer.Origin = request.GetProperty("district").ToString();
                volunteer.Volunteertype = request.GetProperty("volunteerType").ToString();

                myContext.DatabaseVolunteers.Add(volunteer);
                myContext.SaveChanges();

                Result res = new();

                return res.Info;
            }
                
            
            
           
        }
        [HttpDelete()]
        //[Authorize]
        public Dictionary<string, dynamic> VolunteerDelete(dynamic postdata)//删除志愿登记
        {
            string ID = postdata.GetProperty("ID").ToString();
            bool num2 = myContext.DatabaseVolunteers.Any(b => b.Id == ID);//判断是否存在志愿信息
            Console.WriteLine(num2);
            
            if (num2 == false)
            {
                Result res = new Result(0, "不存在该志愿者");

                return res.Info;
            }
            else
            {
                DatabaseVolunteer delvo = myContext.DatabaseVolunteers.Single(b => b.Id == ID);
                myContext.DatabaseVolunteers.Remove(delvo);
                myContext.SaveChanges();
                

                Result res = new();

                return res.Info;
            }
        }

        [HttpGet]
        //[Authorize]
        public Dictionary<string, dynamic> GetVol()//获取志愿申请
        {
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
            List<Dictionary<string, dynamic>> data1_list = new ();
            //在PERSON表中查找
            var vol = myContext.DatabaseVolunteers.ToList();
            foreach(var c in vol) {
                Dictionary<string, dynamic> data1 = new Dictionary<string, dynamic>();
                data1.Add("personId", c.Id);
                data1.Add("volunteerLocation", c.Location);
                data1.Add("date1", c.Servedate);
                data1.Add("district", c.Origin);
                data1.Add("volunteerType", c.Volunteertype);
                DatabasePerson person = myContext.DatabasePerson.Single(b => b.Id == c.Id);
                data1.Add("name", person.Name);
                data1_list.Add(data1);
                 }
            data.Add("volunteerRecord", data1_list);
                Result res = new(20000, "", data);

                return res.Info;
            
        }
        [HttpPut()]
        //[Authorize]
        public Dictionary<string, dynamic> ChangeVol(dynamic request)//修改志愿申请
        {
            string personId = request.GetProperty("volunteerID").ToString();
            string volunteerLocation = request.GetProperty("volunteerLocation").ToString();
            string date1 = request.GetProperty("date1").ToString();
           
            string volunteerType = request.GetProperty("volunteerType").ToString();
            string name = request.GetProperty("name").ToString();


            bool num1 = myContext.DatabasePerson.Any(b => b.Id == personId);//判断是否有这个人
            Console.WriteLine(num1);

            if (num1 == false)
            {

                Result res = new Result(0, "该用户不存在！");

                return res.Info;
            }
            else
            {

                DatabasePerson person = myContext.DatabasePerson.Single(b => b.Id == personId);
                person.Name = name;
                myContext.SaveChanges();

                DatabaseVolunteer vol = myContext.DatabaseVolunteers.Single(b => b.Id == personId);
                
                vol.Location = volunteerLocation;
                vol.Servedate = date1;
                vol.Volunteertype = volunteerType;
                myContext.SaveChanges();

                Result res = new();

                return res.Info;
            }
            


        }
    }
}
