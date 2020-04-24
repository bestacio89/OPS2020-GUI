using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OutilEnquete.Models;

namespace OutilEnquete.Controllers
{
    [Authorize]
    public class QuestionnaireController : Controller
    {
        private readonly ApplicationDbContext _db;

        public QuestionnaireController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var surveys = _db.Surveys.ToList();
            return View(surveys);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var survey = new Questionnaire
                {
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddYears(1)
                };

            return View(survey);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Questionnaire survey, string action)
        {
            if (ModelState.IsValid)
            {
                survey.Questions.ForEach(q => q.CreatedOn = q.ModifiedOn = DateTime.Now);
                _db.Surveys.Add(survey);
                _db.SaveChanges();
                TempData["success"] = "The survey was successfully created!";
                return RedirectToAction("Edit", new {id = survey.Id});
            }
            else
            {
                TempData["error"] = "An error occurred while attempting to create this survey.";
                return View(survey);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var survey = _db.Surveys.Include("Questions").Single(x => x.Id == id);
            survey.Questions = survey.Questions.OrderBy(q => q.Priority).ToList();
            return View(survey);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Questionnaire model)
        {
            foreach (var question in model.Questions)
            {
                question.SurveyId = model.Id;

                if (question.Id == 0)
                {
                    question.CreatedOn = DateTime.Now;
                    question.ModifiedOn = DateTime.Now;
                    _db.Entry(question).State = EntityState.Added;
                }
                else
                {
                    question.ModifiedOn = DateTime.Now;
                    _db.Entry(question).State = EntityState.Modified;
                    _db.Entry(question).Property(x => x.CreatedOn).IsModified = false;
                }
            }

            _db.Entry(model).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Edit", new {id = model.Id});
        }

        [HttpPost]
        public ActionResult Delete(Questionnaire survey)
        {
            _db.Entry(survey).State = EntityState.Deleted;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
