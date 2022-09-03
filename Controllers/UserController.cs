using DB_docker_net5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using DB_docker_net5.IdentityServer;
using JWT;
using JWT.Algorithms;
using JWT.Exceptions;
using JWT.Serializers;
using System.IdentityModel.Tokens.Jwt;

namespace DB_docker_net5.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ModelContext myContext; // 创建一个模型上下文对象
        private readonly IAuthenticateService _authenservice;
        public UserController(ModelContext modelContext, IAuthenticateService service)
        {
            myContext = modelContext;
            _authenservice = service;
        }

        [HttpGet("info")]
        public Dictionary<string, dynamic> getInfo()
        {
            string authHeader = this.HttpContext.Request.Headers["Token"];
            //string token = authHeader.Replace("Bearer ", "");
            int code = 20000;
            string mes = "success";
            var handler = new JwtSecurityTokenHandler();
            var payload = handler.ReadJwtToken(authHeader).Payload;
            var claims = payload.Claims;
            string id = claims.First(claim => claim.Type == "Name").Value;
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
            bool isSuccess = myContext.DatabaseUsers.Any(a => a.Id == id);
            if (isSuccess)
            {
                var person = myContext.DatabasePerson.Single(a => a.Id == id);
                var user = myContext.DatabaseUsers.Single(a => a.Id == id);
                if (user.Username == "admin")
                {
                    string[] strings = new string[1];
                    strings[0] = "admin";
                    data.Add("roles", strings);
                }
                else
                {
                    string[] strings = new string[1];
                    strings[0] = "user";
                    data.Add("roles", strings);
                }
                data.Add("name", user.Username);
                data.Add("phoneNumber", person.Phonenumber);
                data.Add("ID", person.Id);
                data.Add("age", person.Age);
                data.Add("gender", person.Gender);

                Result res = new(20000, "success", data);
                return res.Info;
            }
            else
            {
                Result res = new(0, id);
                return res.Info;
            }

        }

        [HttpPost("editInfo")]

        public Dictionary<string, dynamic> editUserInfo([FromBody] dynamic postdata)
        {
            Result res = new Result();

            string userName = postdata.GetProperty("userName").ToString();
            string gender = postdata.GetProperty("gender").ToString();
            string phoneNumber = postdata.GetProperty("phoneNumber").ToString();
            string age = postdata.GetProperty("age").ToString();


            var user = myContext.DatabaseUsers.Single(a => a.Username == userName);
            string ID = user.Id;
            var person = myContext.DatabasePerson.Single(a => a.Id == ID);

            person.Gender = gender;
            person.Phonenumber = phoneNumber;
            person.Age = age;

            myContext.SaveChanges();

            return res.Info;
        }

        [HttpPost("register")]
        public Dictionary<string, dynamic> Register([FromBody] dynamic postdata)
        {
            Result res = new Result();
            string userName = postdata.GetProperty("userName").ToString();
            string ID = postdata.GetProperty("ID").ToString();
            string passWord = postdata.GetProperty("passWord").ToString();
            string gender = postdata.GetProperty("gender").ToString();
            string age = postdata.GetProperty("age").ToString();
            string phoneNumber = postdata.GetProperty("phoneNumber").ToString();
            string address = postdata.GetProperty("address").ToString();
            string Name = postdata.GetProperty("Name").ToString();

            DatabaseUser user = new();
            user.Id = ID;
            user.Password = passWord;
            user.Loginstatus = "0";
            user.Username = userName;

            myContext.DatabaseUsers.Add(user);

            DatabasePerson person = new();
            person.Id = ID;
            person.Name = Name;
            person.Gender = gender;
            
            person.Age = age;
            person.Address = address;
            
            myContext.DatabasePerson.Add(person);

            myContext.SaveChanges();
            return res.Info;
        }

        [HttpPost("login")]
        public Dictionary<string, dynamic> login(dynamic postdata)
        {
           
            string userName = postdata.GetProperty("userName").ToString();
            string passWord = postdata.GetProperty("passWord").ToString();

            bool isSuccess = myContext.DatabaseUsers.Any(a => a.Id == userName);
            if (!isSuccess)
            {
                Result res = new(0, "不存在的用户名");
                return res.Info;
            }

            var user = myContext.DatabaseUsers.Single(a => a.Id == userName);
            string password = user.Password;

            if(password == passWord)
            {
                Result res_success = new(20000, "success");
                user.Loginstatus = "1";
                myContext.SaveChanges();

                User token_user = new User();
                token_user.UserName = userName;
                token_user.PWD = password;

                string token;
                if (_authenservice.IsAuthenticated(token_user, out token))
                {
                    //if success,return token,it's a string i guess
                    res_success.Info.Add("token", token);
                    return res_success.Info;
                }
                else
                {
                    res_success.Info["code"] = 0;
                    res_success.Info["message"] = "toekn error";
                    return res_success.Info;
                }
                
            }
            else
            {
                Result res_error = new(0,"password error");
                return res_error.Info;
            }
            
        }

        [HttpPost("password")]
        public Dictionary<string, dynamic> password([FromBody] dynamic postdata)
        {
           

            string oldpasswd = postdata.GetProperty("oldPassWord").ToString();
            string newpasswd = postdata.GetProperty("newPassWord").ToString();

          

            int code = 50008;
            string mes = "wrong password";
            bool isSuccess = myContext.DatabaseUsers.Any(b => b.Password == oldpasswd);
            if (!isSuccess)
            {
                Result res = new(0, "输入旧密码错误");
                return res.Info;
            }

            DatabaseUser user = myContext.DatabaseUsers.Single(b => b.Password == oldpasswd);


            user.Password = newpasswd;
            myContext.SaveChanges();
            code = 20000;
            mes = "success";

            Result info = new Result(code, mes);
            return info.Info;
        }

    }
}
