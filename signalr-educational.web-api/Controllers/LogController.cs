using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.Educational.WebApi.DataTransferObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalR.Educational.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogController : ControllerBase
    {
        private readonly IHubContext<Hub> hub;

        public LogController(IHubContext<Hub> hub)
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
