using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ncshib.Controllers
{
    [Route("api/protected")]
    [Produces("application/json")]
    [ApiController]
    public class ProtectedController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<object> Get()
        {
            var map = new Dictionary<string, string>();
            foreach (var header in Request.Headers)
            {
                map.Add(header.Key, header.Value);
            }
            return Ok(map);
        }
    }
}



