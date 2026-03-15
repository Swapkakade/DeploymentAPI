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
        [Route("/feature-deployment-demo")]
        [HttpGet]
        public ActionResult Index1()
        {
            return Ok("Feature branch. Hello World. Checking with deployment on iis");
        }
    }
}
