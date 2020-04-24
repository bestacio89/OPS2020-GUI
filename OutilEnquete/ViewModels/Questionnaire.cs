using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace OutilEnquete.Models
{
    public class Questionnaire
    {
        public Questionnaire()
        {
            Questions = new List<Question>();
            Reponses = new List<Answer>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Question> Questions { get; set; }

        public List<Answer> Responses { get; set; }

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