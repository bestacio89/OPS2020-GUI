namespace OutilEnquete.Constants
{
    public class ApiConstants
    {
        public const string BaseApiUrl = "http://192.168.1.35:5000/";
        public const string DashboardEndpoint = "api/catalog/ProduitsFormation/"; 
        public const string QuestionnaireEndpoint = "api/catalog/ProduitsFprmation/Questionnaires/"; 
        public const string QuestionnaireCreateEndpoint = "api/catalog/ProduitsFprmation/Questionnaires/New";
        public const string ModifierQuesitonnaireEndpoint = "api/catalog/ProduitsFprmation/Questionnaires/Submit";
        public const string AddContactInfoEndpoint = "api/contact";
        public const string PlaceOrderEndpoint = "api/order";
        public const string RegisterEndpoint = "api/authentication/register";
        public const string AuthenticateEndpoint = "api/authentication/authenticate";
        public const string SoumettreReponseEnPoint = "api/Questionnaire/Reponse";

    }
}
