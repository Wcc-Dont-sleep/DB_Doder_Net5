using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB_docker_net5
{
   
    public class Result
    {
        public Dictionary<string, dynamic> Info { get; set; } = new Dictionary<string, dynamic>();

        public Result(int c = 20000,string mes = "", Dictionary<string, dynamic> data = null)
        {
            Info.Add("code", c);
            Info.Add("message", mes);
            Info.Add("data", data);
        }   
    }
    public class Data
    {

        public Dictionary<string, dynamic> data { get; set; } = new Dictionary<string, dynamic>();

        
        
        //public Dictionary<string,dynamic> data { get; set; } =  new Dictionary<string,dynamic>();    
        
    }
}
