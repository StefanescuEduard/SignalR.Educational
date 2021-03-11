using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.Educational.WebApi.DataTransferObjects;
using SignalR.Educational.WebApi.Hubs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalR.Educational.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogController : ControllerBase
    {
        private readonly IHubContext<LogHub> hub;

        public LogController(IHubContext<LogHub> hub)
        {
            this.hub = hub;
        }

        [HttpPost]
        public async Task<IActionResult> Receive([FromBody] IEnumerable<LogDto> logs)
        {
            await hub.Clients.All.SendAsync("transfer-logs", logs);

            return Ok();
        }
    }
}
