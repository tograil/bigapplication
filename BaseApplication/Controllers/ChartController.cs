using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseApplication.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Chart")]
    public class ChartController : Controller
    {

    }
}