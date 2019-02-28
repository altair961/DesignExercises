using WebShop.Notification.Dto;

namespace WebShop.Notification.Interfaces
{
    public interface IGetCustomerNameById
    {
        GetCustomerNameByIdResponse GetCustomerNameById(GetCustomerNameByIdRequest request);
    }
}