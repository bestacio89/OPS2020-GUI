using System;
using System.Threading.Tasks;
using Akavache;
using OutilEnquete.Constants;
using OutilEnquete.Contracts.Repository;
using OutilEnquete.Contracts.Services.Data;
using OutilEnquete.Models;

namespace OutilEnquete.Services.Data
{
    public class ContactDataService : BaseService, IContactDataService
    {
        private readonly IGenericRepository _genericRepository;

        public ContactDataService(IGenericRepository genericRepository, IBlobCache cache = null) : base(cache)
        {
            _genericRepository = genericRepository;
        }

        public async Task<ContactInfo> AddContactInfo(ContactInfo contactInfo)
        {
            UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl)
            {
                Path = ApiConstants.AddContactInfoEndpoint
            };

            var result = await _genericRepository.PostAsync(builder.ToString(), contactInfo);

            return result;
        }
    }
}
