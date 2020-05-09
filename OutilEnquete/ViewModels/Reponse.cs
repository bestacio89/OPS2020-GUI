using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using OPS.BOL;

namespace OutilEnquete.ViewModels
{
    public class Reponse
    {
        public readonly int Score;

        [Key]
        public int Id { get; set; }

        public int IdQuestionnaire { get; set; }

        public QuestionnaireViewModel Questionnaire2 { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public ICollection<WReponse> Answers { get; set; }

        public int GetQuestionCount()
        {
            return Answers == null ? 0 : Answers.Count();
        }

 
        
        public bool  FinQuestionnaire()
        {
            var questions = GetQuestionCount();


            if (questions < Answers.Count())

            {
                return false;
            }

            return true;
        }
    }
}