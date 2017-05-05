using System.Web.Http;
using JWT.Filters;

namespace JWT.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/
        [JwtAuthentication]
        public string Get()
        {
            return "value";
        }

    }
}
