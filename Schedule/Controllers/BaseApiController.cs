using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Schedule.Controllers
{

    [ApiController]
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {

    }
}
