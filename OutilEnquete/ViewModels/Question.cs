using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using OPS.BOL;
namespace OutilEnquete.ViewModels
{
    [DataContract]
    [JsonObject]
    public class Question
    { 
       [JsonProperty(PropertyName =  "IdQuestion")]
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
        public bool EstModifiable { get; set; }

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
    }
}