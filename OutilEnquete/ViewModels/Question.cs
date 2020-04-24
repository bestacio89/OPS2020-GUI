using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using OPS.BOL;
namespace OutilEnquete.Models
{
    [DataContract]
    public class Question : Questionnaire
    { 
        public int QuestionID { get; set; }
        public int IdQuesttionnaire { get; set; }

        public string Title { get; set; }
        
        public string Type { get; set; }

        public string Contenu { get; set; }

        public int Priorité { get; set; }

        public bool IsActive { get; set; }

        public DateTime DateCreation { get; set; }

        public DateTime DataModif { get; set; }

        public List<Answer> Answers { get; set; }
    }
}