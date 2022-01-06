using AspnetRunBasicBlazorApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetRunBasicBlazorApp.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
