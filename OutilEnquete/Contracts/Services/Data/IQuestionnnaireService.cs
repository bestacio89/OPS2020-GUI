using System.Threading.Tasks;
using OPS.BOL;

namespace OutilEnquete.Contracts.Services.Data
{
    public interface IQuesitonnnaireService
    {
        Task<Questionnaire> QuestionnaireByFormation (string userId);
        
    }
}
