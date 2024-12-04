using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace RoomEndPoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateGameController : ControllerBase
    {
        [HttpGet("connect")]
        public async Task Connect()
        {
            if (HttpContext.WebSockets.IsWebSocketRequest)
            {
                var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();

                // do something here
            }
            else
            {
                HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }
    }
}
