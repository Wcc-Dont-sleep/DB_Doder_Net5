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
    [Route("personalRequest")]

    public class DemandController : Controller//个人表单查询与提交
    {
        private readonly ModelContext myContext; // 创建一个模型上下文对象
        // 构造函数，在每次调用该Controller中的api函数时，都会创建一个context对象用于操作数据库
        public DemandController(ModelContext modelContext)
        {
            myContext = modelContext;
        }
        [HttpGet("{ID}")]
        //[Authorize]
        public Dictionary<string, dynamic> GetDemand(string ID)//根据personId找个人需求表单
        {
            string personId = ID.Trim();
            Dictionary<string, dynamic> data = new Dictionary<string,dynamic>();
            List<Dictionary<string, dynamic>> data1_list = new();
            bool num1 = myContext.DatabasePerson.Any(b => b.Id == personId);//判断是否有这个人
            Console.WriteLine(num1);  
            
            if (num1 == false)
            {

                Result res = new Result(0, personId);

                return res.Info;
            }
            else
            {
                //在PERSON表中查找
                DatabasePerson person = myContext.DatabasePerson.Single(b => b.Id == personId);
                

                //bool num2 = myContext.DatabaseWritedemandform.Any(b => b.Personid == personId);//判断是否存在
                //Console.WriteLine(num2);
                var writedemand = myContext.DatabaseWritedemandforms.Where(b => b.Personid == personId).Select(b => new { b.Personid,b.Writetime, b.Demandformid });
                //根据需求者编号找出需求表单编号

                foreach (var c in writedemand)
                { //根据需求表单编号找出物资名称、种类、数量
                    DatabaseDemandform demand = myContext.DatabaseDemandforms.Single(b => b.Id == c.Demandformid);
                    //DatabaseDemandform newdemand = new();
                    //newdemand.Id = demand.Id;
                    //newdemand.Goodsname = demand.Goodsname;
                    //newdemand.Type = demand.Type;
                    //newdemand.Num = demand.Num;
                    Dictionary<string, dynamic> data1 = new Dictionary<string, dynamic>();
                  
                    data1.Add("personId", personId);
                    data1.Add("name", person.Name);
                    data1.Add("phoneNumber", person.Phonenumber);
                    data1.Add("gender", Convert.ToInt32(person.Gender));//gender是int型
                    data1.Add("Demandformid", demand.Id);
                    data1.Add("goodsName", demand.Goodsname);
                    data1.Add("type", demand.Type);
                    data1.Add("num", (int)demand.Num);//num是int型
                    data1.Add("writeTime", c.Writetime);//num是int型
                    data1_list.Add( data1);
                }
                data.Add("personalRequest", data1_list);
                Result res = new(20000,"", data);

                return res.Info;
            }
        }



        [HttpPost]
        //[Authorize]
        public Dictionary<string, dynamic> DemandWrite(dynamic request)//填写表单
        {
            re: Random ran = new Random();
            int n = ran.Next(10000);
            //自动生成需求表单编号
            string demandID = n.ToString();

            var list = myContext.DatabaseDemandforms.ToList();
            foreach (var c in list)
            {
                if (c.Id == demandID) goto re;
            }
        
            string personID = request.GetProperty("personId").ToString().Trim();
            bool num1 = myContext.DatabasePerson.Any(b => b.Id == personID);//判断是否有这个人
            if (num1 == false)//没有这个人
            {
                DatabasePerson person = new DatabasePerson();//插入Person

                person.Id = request.GetProperty("personId").ToString();
                person.Name = "user";
                
                person.Phonenumber = "111";
                person.Gender = "1";
                myContext.DatabasePerson.Add(person);
                myContext.SaveChanges();
            }
            DatabaseDemandform demandform = new DatabaseDemandform();//插入Demandform
            demandform.Id = demandID;
            demandform.Goodsname = request.GetProperty("goodsName").ToString();
            demandform.Type = request.GetProperty("type").ToString();
            demandform.Num = decimal.Parse(request.GetProperty("num").ToString());
            myContext.DatabaseDemandforms.Add(demandform);
            myContext.SaveChanges();

            DatabaseWritedemandform writedemand = new DatabaseWritedemandform();//插入Writedemandform
            writedemand.Personid = request.GetProperty("personId").ToString();
            writedemand.Writetime = request.GetProperty("writeTime").ToString();
            writedemand.Demandformid = demandID;
            //sql添加数据方法，每次传入为数据的某个表，调用完后必须保存更改，即调用           
            myContext.DatabaseWritedemandforms.Add(writedemand);
            myContext.SaveChanges();
            //string sql = "insert into DATABASE_WRITEDEMANDFORM(PERSONID,WRITETIME,DEMANDFORMID)values(" +
            //request.id + ",'" + request.createTime + "','" + demandID + "')";

            
            Result res = new();

            return res.Info;
        }
        [HttpPut]
        //[Authorize]
        public Dictionary<string, dynamic> DemandChange(dynamic request)//修改个人表单
        {
            string personId = request.GetProperty("personId").ToString();
            string name = request.GetProperty("name").ToString();
            string phonenum = request.GetProperty("phoneNumber").ToString();       
            string Demandformid = request.GetProperty("Demandformid").ToString();
            string goodsName = request.GetProperty("goodsName").ToString();
            string type = request.GetProperty("type").ToString();
            string writeTime = request.GetProperty("writeTime").ToString();


            bool num1 = myContext.DatabasePerson.Any(b => b.Id == personId);//判断是否有这个人
            Console.WriteLine(num1);

            if (num1 == false)
            {

                Result res = new Result(0, "该用户不存在！");

                return res.Info;
            }
            else {

                DatabasePerson person = myContext.DatabasePerson.Single(b => b.Id == personId);
                
                person.Name = name;
                person.Phonenumber = phonenum;              
                myContext.SaveChanges();

                DatabaseWritedemandform writedemand = myContext.DatabaseWritedemandforms.Single(b => b.Personid == personId&& b.Demandformid== Demandformid);

                writedemand.Writetime = writeTime;
                myContext.SaveChanges();

                DatabaseDemandform demandform = myContext.DatabaseDemandforms.Single(b => b.Id ==Demandformid);
                demandform.Id = Demandformid;
                demandform.Goodsname = goodsName;
                demandform.Type = type;
                demandform.Num = decimal.Parse(request.GetProperty("num").ToString());
                myContext.SaveChanges();

                Result res = new();

                return res.Info;
            }
           
            
        }
        [HttpDelete]
        //[Authorize]
        public Dictionary<string, dynamic> DemandDelete(dynamic postdata)//删除个人表单
        {

            string personId = postdata.GetProperty("personId").ToString();
            string demandFormId = postdata.GetProperty("demandId").ToString();

            bool num1 = myContext.DatabasePerson.Any(b => b.Id == personId);//判断是否有这个人
            Console.WriteLine(num1);
            bool num2 = myContext.DatabaseWritedemandforms.Any(b => b.Personid == personId&&b.Demandformid== demandFormId);//判断人与表单的对应关系
            Console.WriteLine(num2);
            bool num3 = myContext.DatabaseDemandforms.Any(b => b.Id == demandFormId);//判断是否有这个表单
            Console.WriteLine(num3);
            if (num1 == false || num2 == false || num3 == false)
            {
                Result res = new Result(0, "请求错误");

                return res.Info;
            }
            else
            {
                DatabaseWritedemandform delwrite = myContext.DatabaseWritedemandforms.Single(b => b.Personid == personId && b.Demandformid == demandFormId);
                myContext.DatabaseWritedemandforms.Remove(delwrite);
                myContext.SaveChanges();

                //DatabasePerson delperson = myContext.DatabasePerson.Single(b => b.Id == personId);
                //myContext.DatabasePerson.Remove(delperson);
                //myContext.SaveChanges();
                
                DatabaseDemandform deldemand = myContext.DatabaseDemandforms.Single(b => b.Id == demandFormId);
                myContext.DatabaseDemandforms.Remove(deldemand);
                myContext.SaveChanges();

                //string demandID = "000";
                //int plus = 0;
                //var list6 = myContext.DatabaseDemandforms.Select(b=>new { b.Id }).ToList();
                //foreach(var list in list6)
                //{
                //    plus++; 
                //    demandID = "00" + plus.ToString();
                //    DatabaseDemandform demand = myContext.DatabaseDemandforms.Single(b=>b.Id== list.Id);
                //    demand.Id = demandID;
                //    myContext.SaveChanges();
                //}
                
                

                Result res = new();

                return res.Info;
            }
        }

     }
}
