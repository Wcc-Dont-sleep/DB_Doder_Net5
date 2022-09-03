using Microsoft.AspNetCore.Mvc;
using DB_docker_net5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DB_docker_net5.Controllers
{
    [ApiController]
    [Route("existingMaterial")]
    public class MaterialGoodsController : ControllerBase
    {
        private readonly ModelContext myContext;

        //补上默认对象传入
        public MaterialGoodsController(ModelContext modelContext)
        {
            myContext = modelContext;
        }
        //从此开始写代码
        [HttpGet]
        public Dictionary<string, dynamic> GetGoodsInfo()
        {
            List<Dictionary<string, dynamic>> existingMaterial_list = new();
            Dictionary<string, dynamic> data = new();

            var UnitPurchase = myContext.DatabaseUnitspurchases;
            foreach(var unit in UnitPurchase)
            {
                var good = myContext.DatabaseGoods.Single(a => a.Id == unit.Goodsid);
                var epic = myContext.DatabaseEpidemiccontrolunits.Single(a => a.Id == unit.Epidemiccontrolunitsid);
                Dictionary<string, dynamic> existingMaterial = new();

                existingMaterial.Add("goodsId", good.Id);
                existingMaterial.Add("goodsType", good.Type);
                existingMaterial.Add("goodsName", good.Name);
                existingMaterial.Add("count", good.Num);
                existingMaterial.Add("units", epic.Name);
                existingMaterial.Add("unitsPhone", epic.Phonenumber);
                existingMaterial.Add("updateTime", DateTime.Now.ToString());

                existingMaterial_list.Add(existingMaterial);
            }

            data.Add("existingMaterial", existingMaterial_list);
            Result res = new(20000, "success", data);

            return res.Info;
        }

        [HttpDelete]
        public Dictionary<string, dynamic> DeleteGoodsInfo(dynamic postdata)
        {
            string unit = postdata.GetProperty("unitName").ToString();
            string goodsId = postdata.GetProperty("goodsId").ToString();

            var units = myContext.DatabaseEpidemiccontrolunits.Single(a => a.Name== unit);
            var unitp = myContext.DatabaseUnitspurchases.Single(a => a.Epidemiccontrolunitsid == units.Id && a.Goodsid == goodsId);

            myContext.DatabaseUnitspurchases.Remove(unitp);
            myContext.SaveChanges();

            Result res = new(20000, unit + "和" + goodsId + "的记录已经删除");
            return res.Info;
        }
    }
}
