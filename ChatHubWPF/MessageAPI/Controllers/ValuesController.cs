using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;
using MessageAPI.Models;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<Message> MessageListDB = new List<Message>();
        public static List<User> users = new List<User>();
        //// GET message/values

        [HttpGet]
        [Route("{From}/{To}")]
        public ActionResult<List<Message>> Get(string From, string To)
        {
            var tempListMessage = new List<Message>();
            foreach (var item in MessageListDB)
            {
                if ((From == item.From && To == item.To) || (From == item.To && To == item.From))
                {
                    tempListMessage.Add(item);
                }
            }
            return tempListMessage;
        }

        [HttpGet]
        public ActionResult<List<Message>> Get()
        {
            return MessageListDB;
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody]Message value)
        {
            MessageListDB.Add(value);
        }

        [HttpDelete]
        public void Delete()
        {
            MessageListDB.Clear();
        }



        //UPDATE CONTROLLER INFO
        [HttpPost]
        [Route("onlineusers/add/{name}")]

        public void AddOnlineUsers(string name)
        {
            users.Add(new User { Name = name });
        }

        [HttpGet]
        [Route("onlineusers")]
        public ActionResult<List<User>> GetOnlineUsers()
        {
            return users;
        }
    }
}