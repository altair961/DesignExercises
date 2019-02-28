using System.Web.Http;

namespace WebShop.Notification.Api
{
    public class NotificationController : ApiController
    {
        [Route("customers/{customerId}")]
        [HttpGet]
        public string FindCustomerNameById(int customerId)
        {
            
            return "John";
        }
    }
}