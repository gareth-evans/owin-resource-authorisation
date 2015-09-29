using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace AuthSpike
{
    public class CarsController : ApiController
    {
        // GET api/<controller>
        [CustomAuthorize]
        public IEnumerable<string> Get()
        {
            throw new HttpResponseException(HttpStatusCode.Unauthorized);

            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}