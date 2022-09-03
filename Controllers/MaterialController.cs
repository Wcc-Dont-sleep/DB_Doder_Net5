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
    [Route("needData")]
    public class MaterialController : ControllerBase//物资需求统计与查看
    {
        private readonly ModelContext myContext; // 创建一个模型上下文对象
        // 构造函数，在每次调用该Controller中的api函数时，都会创建一个context对象用于操作数据库
        public MaterialController(ModelContext modelContext)
        {
            myContext = modelContext;
        }
        [HttpGet]
        //[Authorize]
        public Dictionary<string, dynamic> ViewMaterial()//疫情防控单位查看物资需求
        {
            Dictionary<string, dynamic> needData = new Dictionary<string, dynamic>();
            List<List<Dictionary<string, dynamic>>> needData_list = new();
            
            List<Dictionary<string, dynamic>> needData1_list = new();
            DatabaseManage manage1 = new();
            //bool num1 = myContext.DatabaseManages.Any(b => b.Epidemiccontrolunitsid == unitID);//判断是否有这个疫情防控单位
            //Console.WriteLine(num1);
            //if (num1 == false)
            //{

            //    Result res = new Result(0, "该疫情防控单位不存在！");

            //    return res.Info;
            //}
            //else
            //{
            var manage = myContext.DatabaseManages.Select(b => new { b.Epidemiccontrolunitsid, b.Personid }).ToList();//根据疫情防控单位ID找出需求者ID
                foreach (var c in manage)//遍历该疫情防控单位下的每个人
                {

                    //根据需求者编号找出姓名和电话
                    DatabasePerson person = myContext.DatabasePerson.Single(b => b.Id == c.Personid);


                    var writedemand = myContext.DatabaseWritedemandforms.Where(b => b.Personid == c.Personid).Select(b => new { b.Personid, b.Demandformid }).ToList();//根据需求者编号找出需求表单编号
                                                                                                                                                                       //统计，将疫情防控单位ID和需求表单ID对应起来
                    foreach (var e in writedemand)
                    {
                        Dictionary<string, dynamic> needData1 = new Dictionary<string, dynamic>();
                    //DatabaseViewdemandform viewdemand = new DatabaseViewdemandform();
                    //viewdemand.Epidemiccontrolunitsid = unitID;
                    //viewdemand.Demandformid = e.Demandformid;
                    //myContext.DatabaseViewdemandforms.Add(viewdemand);
                    //myContext.SaveChanges();
                    manage1 = myContext.DatabaseManages.Single(b => b.Personid == c.Personid);
                    var ep = myContext.DatabaseEpidemiccontrolunits.Single(a => a.Id == manage1.Epidemiccontrolunitsid);

                    needData1.Add("unitId", manage1.Epidemiccontrolunitsid);
                    needData1.Add("unitName",ep.Name);

                    needData1.Add("id", c.Personid);//需求者编号
                    needData1.Add("demandID", e.Demandformid);
                    needData1.Add("name", person.Name);
                    needData1.Add("phoneNumber", person.Phonenumber);

                    DatabaseDemandform demand = myContext.DatabaseDemandforms.Single(b => b.Id == e.Demandformid);
                    needData1.Add("goodName", demand.Goodsname);
                    needData1.Add("type", demand.Type);
                    needData1.Add("num", (int)demand.Num);
                    needData1_list.Add(needData1);
                    }
                    
                    needData_list.Add(needData1_list);
                }
                needData.Add("needData", needData1_list);

                Result res = new(20000, "", needData);

                return res.Info;
            //}

        }
        [HttpDelete]
        public Dictionary<string, dynamic> deleteGoodsInfo(dynamic postdata)
        {
            string ID = postdata.GetProperty("id").ToString();
            string demandID = postdata.GetProperty("demandID").ToString();

            bool isSuccess1 = myContext.DatabaseWritedemandforms.Any(a => a.Personid == ID && a.Demandformid == demandID);
            if (!isSuccess1)
            {
                Result res_error = new(0, "用户ID或需求表单ID不存在");
                return res_error.Info;
            }
            var writeform = myContext.DatabaseWritedemandforms.Single(a => a.Personid == ID && a.Demandformid == demandID);
            myContext.DatabaseWritedemandforms.Remove(writeform);
            myContext.SaveChanges();

            var demandfrom = myContext.DatabaseDemandforms.Single(a => a.Id == demandID);
            myContext.DatabaseDemandforms.Remove(demandfrom);
            myContext.SaveChanges();

            Result res = new(20000, "删除ID为" + ID + "表单号为" + demandID + "的需求表单信息成功");
            return res.Info;          
        }

    }
}
