﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiActionOverloadingNew.Controllers
{
    public class TestController : ApiController
    {
        // GET api/values
        [ActionName("GetAll")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [ActionName("GetById")]
        public string Get(int id)
        {
            return "value";
        }

        [ActionName("GetByGUID")]
        public string Get(Guid id)
        {
            return "value";
        }

        [ActionName("GetByString")]
        public string Get(string id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
