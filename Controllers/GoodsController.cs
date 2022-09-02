using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB_docker_net5.Models;

namespace DB_docker_net5.Controllers
{
    [ApiController]
    [Route("donateData")]
    public class GoodsController : ControllerBase
    {
        private readonly ModelContext myContext; // 创建一个模型上下文对象

        // 构造函数，在每次调用该Controller中的api函数时，都会创建一个context对象用于操作数据库
        //这个对象在model文件夹里面的ModelContext.cs里面，调用此需要引入DB_docker_net5.Models（命名空间.类名）
        //该类封装了sql语句，可以直接按照函数调用，详见示例
        public GoodsController(ModelContext modelContext)
        {
            myContext = modelContext;
        }

        [HttpPost]
        public Dictionary<string, dynamic> Donor(dynamic request)
        {
            //Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
            //data.Add("name", 12345);
            //data.Add("ID", "12345");

            string unitID = request.GetProperty("unitID").ToString();
            string donorID = request.GetProperty("donorID").ToString();
            string goodsID = request.GetProperty("goodsID").ToString();
            string date = request.GetProperty("date2").ToString();
            
            
            bool num1 = myContext.DatabaseDonors.Any(b => b.Id == donorID);
            Console.WriteLine(num1);
            bool num2 = myContext.DatabaseEpidemiccontrolunits.Any(b => b.Id == unitID);
            Console.WriteLine(num2);
            bool num3 = myContext.DatabaseGoods.Any(b => b.Id == goodsID);
            Console.WriteLine(num3);

            if (num1 == false || num2 == false || num3 == false)
            {
                
                Result res =  new Result(0,"ID有误");
                
                return res.Info;
            }
            else
            {
                DatabaseDonatetounit du = new DatabaseDonatetounit { Donorid = donorID, Epidemiccontrolunitsid = unitID, Goodsid = goodsID, Donatetime = date };
                myContext.DatabaseDonatetounits.Add(du);

                Result res = new();

                return res.Info;
            }

        }
    }
}
