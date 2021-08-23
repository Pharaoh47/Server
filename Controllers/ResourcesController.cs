using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Server.Model;


namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResourcesController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<Resource> Index([FromServices] Context context)
            => context.Resources.ToList();

        [Route("")]
        [HttpOptions]
        public object Meta([FromServices] Context context)
            => new { Count = context.Resources.Count() };
    }


}