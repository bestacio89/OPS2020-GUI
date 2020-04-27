using System.Threading.Tasks;
using Intuit.Ipp.Data;
using OPS.DAL;
using OPS.BOL;

namespace OutilEnquete.Contracts.Services.Data
{
    public interface IContactDataService
    {
        Task<ContactInfo> AddContactInfo(ContactInfo contactInfo);
    }
}
