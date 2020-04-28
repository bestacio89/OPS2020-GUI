using System;
using System.Threading.Tasks;
using OutilEnquete.Constants;
using OutilEnquete.Contracts.Repository;
using OutilEnquete.Contracts.Services.Data;
using OutilEnquete.Models;

namespace OutilEnquete.Services.Data
{
    public class OrderDataService : IOrderDataService
    {
        private readonly IGenericRepository _genericRepository;

        public OrderDataService(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<Order> PlaceOrder(Order order)
        {
            UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl)
            {
                Path = ApiConstants.PlaceOrderEndpoint
            };

            var result =
                await _genericRepository.PostAsync<Order>(builder.ToString(), order);

            return order;
        }
    }
}
