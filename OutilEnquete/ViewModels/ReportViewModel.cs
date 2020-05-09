using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using OutilEnquete.Models;

namespace OutilEnquete.ViewModels
{
    public class ReportViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public QuestionnaireViewModel Survey { get; set; }
        public List<QuestionViewModel> Responses { get; set; }
    }
    [DataContract]
    [JsonObject]
    public class QuestionViewModel
    {
        [JsonProperty(PropertyName = "IdQuestion")]
        public int IdQuestion { get; set; }

        [JsonProperty(PropertyName = "Libelle")]
        public string Libelle { get; set; }

        [JsonProperty(PropertyName = "Typechamp")]
        public string TypeChamp { get; set; }

        [JsonProperty(PropertyName = "TypeResponse")]
        public string TypeReponse { get; set; }

        [JsonProperty(PropertyName = "EstaReponseMultiple")]
        public string EstAReponseMultiple { get; set; }

        [JsonProperty(PropertyName = "EstRequis")]
        public string EstRequis { get; set; }

        [JsonProperty(PropertyName = "EstModifiable")]
        public int EstModifiable { get; set; }

        [JsonProperty(PropertyName = "EstExtensible")]
        public bool EstExtensible { get; set; }

        [JsonProperty(PropertyName = "Graphique")]
        public bool Graphique { get; set; }

        [JsonProperty(PropertyName = "GraphiqueModifiable")]
        public bool GraphiqueModifiable { get; set; }

        [JsonProperty(PropertyName = "TypeGraphique")]
        public string TypeGraphique { get; set; }

        [JsonProperty(PropertyName = "ValeursPossible")]
        public List<string> ValeursPossible { get; set; }

        public DateTime DateCreation { get; set; }

        public DateTime DataModif { get; set; }

        public List<Reponse> Reponses { get; set; }
        //public int Score
        //{
        //   get
        //   {
        //       if (TypeReponse == "Yes/No")
        //           return Reponse.GetQues (x => x.Value == "Yes" ? 1 : 0);

        //       if (TypeReponse == "Valeur")
        //       {
        //           return Answers.Sum(x =>
        //               {
        //                   int num;
        //                   Int32.TryParse(x.Value, out num);
        //                   return num;
        //               });
        //       }

        //       return 0;
        //   }
        //}

        //public int Total
        //{
        //    get { return Answers.Count(); }
        //}

        //public double Percentage
        //{
        //    get { return (double)Score / (double)Total; }
        //}

        //public string PercentageString
        //{
        //    get { return Answers.Any() ? String.Concat((Int32) (Percentage*100), "%") : "0%"; }
        //}
    }
}