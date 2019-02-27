using System.Web.Http;

namespace WebShop.Notification.Api
{
    public class NotificationController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Hello, Web API");
        }
    }
}