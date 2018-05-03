using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinSelfHost
{
    public class ValuesController:ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        public string Get(int id)
        {
            return "value";
        }
        public void Post([FromBody]string vlue)
        {

        }
        public void Put(int id,[FromBody]string value)
        {

        }
        public void Delete(int id)
        {

        }

    }
}
