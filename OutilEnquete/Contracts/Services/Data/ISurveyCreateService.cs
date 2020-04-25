using System.Threading.Tasks;
using OutilEnquete.Models;

namespace OutilEnquete.Contracts.Services.Data
{
    public interface IQuestionaireDataService
    {
        Task<Questionnaire> CreationQuestionaire (Questionnaire Questionnaire);
    }
}
