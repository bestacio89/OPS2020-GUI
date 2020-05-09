using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OPS.DAL;
using OutilEnquete.Models;
using OutilEnquete.ViewModels;
using Newtonsoft.Json;

namespace OutilEnquete.Controllers
{
    [Authorize]
    public class ReponsesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ReponsesController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Index(int surveyId)
        {
            var responses = _db.Reponses
                               .Include("Questionnaire")
                               .Include("Reponse")
                               .Include("Reponse.Question")
                               .Where(x => x.Questionnaire2.IdQuestionnaire == surveyId)
                               .Where(x => x.CreatedBy == User.Identity.Name)
                               .OrderByDescending(x => x.CreatedOn)
                               .ThenByDescending(x => x.Id)
                               .ToList();

            return View(responses);
        }

        [HttpGet]
        public ActionResult Details(int surveyId, int id)
        {
            var response = _db.Reponses
                              .Include("Questionnaire")
                              .Include("Reponses")
                              .Include("Reponses.Question")
                              .Where(x => x.Questionnaire2.IdQuestionnaire == surveyId)
                              .Where(x => x.CreatedBy == User.Identity.Name)
                              .Single(x => x.Id == id);

            response.Answers = response.Answers.OrderBy(x => x.Question.Priority).ToList();
            return View(response);
        }

        [HttpGet]
        public ActionResult Create(int surveyId)
        {
            var survey = _db.Questionnaires
                            .Where(s => s.IdQuestionnaire == surveyId)
                            .Select(s => new
                                {
                                    Survey = s,
                                    Questions = s.DataJson
                                                 .Where(q => q.IsActive)
                                                 .OrderBy(q => q.Priority)
                                })
                             .AsEnumerable()
                             .Select(x =>
                                 {
                                     x.Survey.Questions = x.Questions.ToList();
                                     return x.Survey;
                                 })
                             .Single();

            return View(survey);
        }

        [HttpPost]
        public ActionResult Create(int IdQuestionnaire, string action, Answer model)
        {
            model.Response = model.Response.Where(a => !String.IsNullOrEmpty(a.Value)).ToList();
            model.Id = IdQuestionnaire;
            model.C = User.Identity.Name;
            model.CreatedOn = DateTime.Now;
            _db.Responses.Add(model);
            _db.SaveChanges();

            TempData["success"] = "Your response was successfully saved!";

            return action == "Next"
                       ? RedirectToAction("Create", new {IdQuestionnaire})
                       : RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Delete(int IdQuestionnaire, int id, string returnTo)
        {
            var response = new Answer() { Id = id, SurveyId = IdQuestionnaire };
            _db.Entry(response).State = EntityState.Deleted;
            _db.SaveChanges();
            return Redirect(returnTo ?? Url.RouteUrl("Root"));
        }
    }
}