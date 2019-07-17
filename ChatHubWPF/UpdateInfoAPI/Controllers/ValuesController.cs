using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace UpdateInfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController :ControllerBase
    {
        // GET api/values
        [HttpGet]
        [Route("online")]
        public ActionResult<List<UsersFromTo>> GetAllOnlineUsers()
        {
            return null;//delete this
            //return all online users
        }

        [HttpGet]
        public ActionResult<List<UsersFromTo>> GetOnlineUsers()
        {
            return null;//delete this
            //return all online users
        }

        // GET api/values/5
        [HttpGet]
        [Route("contacts/{username}")]
        public ActionResult<List<UsersFromTo>> GetContactUsers(string username)
        {
            return null;
        }

        [HttpGet]
        [Route("newmessages/{username}")]
        public ActionResult<List<UsersFromTo>> GetNewMessages(string username)
        {
            return null;
        }

        [HttpGet]
        [Route("newcalls/{username}")]
        public ActionResult<List<UsersFromTo>> GetNewVideocalls(string username)
        {
            return null;
        }
    }
}