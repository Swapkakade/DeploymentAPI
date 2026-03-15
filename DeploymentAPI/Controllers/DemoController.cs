using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeploymentAPI.Controllers
{

    [ApiController]
    public class DemoController : ControllerBase
    {
        public DemoController()
        {
        }
        [Route("/deployment-demo")]
        [HttpGet]
        public ActionResult Index2()
        {
            return Ok("Hello World. Checking with deployment on iis");
        }
    }
}
