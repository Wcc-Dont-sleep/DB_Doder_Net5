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
    [Route("purchaseData")]
    [ApiController]


    public class PurchaseDataController : ControllerBase
    {
        private readonly ModelContext myContext;

        public PurchaseDataController(ModelContext modelContext)
        {
            myContext = modelContext;
        }


        //采购信息查询
        [HttpGet]
        public Dictionary<string, dynamic> Get()
        {
            //Result res = new Result();
            List<Dictionary<string, dynamic>> assignmentData_list = new();
            List<Dictionary<string, dynamic>> isolatedPointsData_list = new();
            Dictionary<string, dynamic> data = new();

            var unitList = myContext.DatabaseUnitspurchases;
            foreach (var u in unitList)
            {
                var good = myContext.DatabaseGoods.Single(a => a.Id == u.Goodsid);
                var names = myContext.DatabaseEpidemiccontrolunits.Single(b => b.Id == u.Epidemiccontrolunitsid);
                Dictionary<string, dynamic> assignmentData = new();
                assignmentData.Add("buyerID", u.Epidemiccontrolunitsid);
                assignmentData.Add("buyerName", names.Name);
                assignmentData.Add("purchaseTime", u.Purchasetime);
                assignmentData.Add("materialName", good.Name);
                assignmentData.Add("materialNum", good.Num);
                assignmentData.Add("materialPrice", good.Price);

                assignmentData_list.Add(assignmentData);
            }
            var donorList = myContext.DatabaseDonorpurchases;
            foreach (var d in donorList)
            {
                var good = myContext.DatabaseGoods.Single(a => a.Id == d.Goodsid);
                var names = myContext.DatabaseDonors.Single(b => b.Id == d.Donorid);
                Dictionary<string, dynamic> assignmentData = new();
                assignmentData.Add("buyerID", d.Donorid);
                assignmentData.Add("buyerName", names.Name);
                assignmentData.Add("purchaseTime", d.Purchasetime);
                assignmentData.Add("materialName", good.Name);
                assignmentData.Add("materialNum", good.Num);
                assignmentData.Add("materialPrice", good.Price);

                isolatedPointsData_list.Add(assignmentData);
            }

            data.Add("unitPurchaseData", assignmentData_list);
            data.Add("donorPurchaseData", isolatedPointsData_list);
            Result res = new Result(20000, "", data);
            //res.Info.Add("donorPurchaseData", donor);
            /*foreach (var item in donor)
            {
                Dictionary<string, dynamic> row = new Dictionary<string, dynamic>();
                var type = myContext.DatabaseGoods.Single(a => a.Id == item.Goodsid);
                row.Add("type", type.ToString());
                row.Add("donorpurchase", item.ToString());
                res.Info.Add("row", row);
            }
            var unit = myContext.DatabaseUnitspurchases;
            foreach (var item in unit)
            {
                Dictionary<string, dynamic> row2 = new Dictionary<string, dynamic>();
                var type = myContext.DatabaseGoods.Single(a => a.Id == item.Goodsid);
                row2.Add("type", type.ToString());
                row2.Add("unitpurchase", item.ToString());
                res.Info.Add("row2", row2);
            }*/
            return res.Info;
        }

        /*防疫单位购买物资
         *参数：单位ID、物资ID、购买时间
         */
        [HttpPost("unitPurchase")]
        public Dictionary<string, dynamic> UnitPurchase([FromBody] dynamic postdata)
        {
            Result res = new Result();

            DatabaseUnitspurchase unitspurchase = new DatabaseUnitspurchase();
          
            string eid = postdata.GetProperty("unitID").ToString().Substring(0,10);
            string materialName = postdata.GetProperty("materialName").ToString();
            string purchaseTime = postdata.GetProperty("purchaseTime").ToString();
            string nums = postdata.GetProperty("num").ToString();
            string materialType = postdata.GetProperty("materialType").ToString();
            Random ran = new Random();
            int n = ran.Next(10000);
            //自动生成已购买物资编号
            string materialID = n.ToString();

            Random r = new Random();
            int ns = r.Next(10000);
            //自动生成价格
            
            unitspurchase.Epidemiccontrolunitsid = eid;
            unitspurchase.Goodsid = materialID;
            unitspurchase.Purchasetime = purchaseTime;
            
            

            DatabaseGood newgood = new();
            decimal num = decimal.Parse(nums);
            newgood.Num = num;
            newgood.Id = materialID;
            newgood.Name = materialName;
            newgood.Type = materialType;
            newgood.Price = ns;
            myContext.DatabaseGoods.Add(newgood);
            myContext.DatabaseUnitspurchases.Add(unitspurchase);
            myContext.SaveChanges();

            return res.Info;
        }
        /*
         *捐赠者单位购买物资
         *参数：单位ID、物资ID、购买时间
         */
        [HttpPost("donorPurchase")]
        public Dictionary<string, dynamic> DonorPurchase([FromBody] dynamic postdata)
        {
            Result res = new Result();

            DatabaseDonorpurchase donorspurchase = new DatabaseDonorpurchase();
            string eid = postdata.GetProperty("donorID").ToString().Substring(0, 10);
            string materialName = postdata.GetProperty("materialName").ToString();
            string purchaseTime = postdata.GetProperty("purchaseTime").ToString();
            string nums = postdata.GetProperty("num").ToString();
            string materialType = postdata.GetProperty("materialType").ToString();
            Random ran = new Random();
            int n = ran.Next(10000);
            //自动生成已购买物资编号
            string materialID = n.ToString();

            //物资价格表
            Dictionary<string, int> menu = new();
            menu.Add("食品", 18);
            menu.Add("日常用品", 23);
            menu.Add("防疫用品", 15);
            int price = menu[materialType];

            //自动生成价格

            DatabaseGood newgood = new();
            decimal num = decimal.Parse(nums);
            newgood.Num = num;
            newgood.Id = materialID;
            newgood.Name = materialName;
            newgood.Type = materialType;
            newgood.Price = price;
            myContext.DatabaseGoods.Add(newgood);
          


            donorspurchase.Donorid = eid;
            donorspurchase.Goodsid = materialID;
            donorspurchase.Purchasetime = purchaseTime;
            myContext.DatabaseDonorpurchases.Add(donorspurchase);
            myContext.SaveChanges();


            return res.Info;
        }



    }
}
