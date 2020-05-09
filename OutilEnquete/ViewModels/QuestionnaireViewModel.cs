using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OPS.BOL;

namespace OutilEnquete.ViewModels
{
    public class QuestionnaireViewModel : Questionnaire
    { 
        public QuestionnaireViewModel()
        {
    
        }

        [Key]
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Question> Questions { get { return JsonConvert.DeserializeObject<List<Question>>(this.DataJson); } set { JsonConvert.SerializeObject(this.Questions); } }

        public List<Reponse> Responses { get; set; }

        public bool IsActive
        {
            get { return StartDate < DateTime.Now && EndDate > DateTime.Now; }
        }

        public string ToJson()
        {
            var js = JsonSerializer.Create(new JsonSerializerSettings());
            var jw = new StringWriter();
            js.Serialize(jw, this);
            return jw.ToString();            
        }

    
    }
}