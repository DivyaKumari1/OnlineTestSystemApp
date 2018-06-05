using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineTestSystemApp;

namespace OnlineTestSystemUI.Controllers
{
    public class QuestionsController : Controller
    {
        private TestModel db = new TestModel();

        // GET: Questions
        [Authorize]
        public ActionResult Index()
        {
            var questions= OnlineTestSystemApp.Test.GetAllQuestions(HttpContext.User.Identity.Name);
            return View(questions);
        }

        // GET: Questions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var question = OnlineTestSystemApp.Test.GetAllQuestionDetails(id.Value);
            {
                if (question == null)
                {
                    return HttpNotFound();
                }
                return View(question);
            }
        }

        // GET: Questions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QuestionNumber,EmailId,QuestionText,Option1,Option2,Option3,Option4,CorrectOption,MarkedOption,isAnsweredCorrect,CreatedDate")] Question question)
        {
            if (ModelState.IsValid)
            {
                OnlineTestSystemApp.Test.CreateQuestion(question.QuestionText, question.Option1, question.Option2, question.Option3, question.Option4,Convert.ToInt32(question.EmailId), question.MarkedOption,Convert.ToString(question.CorrectOption));
                
                return RedirectToAction("Index");
            }

            return View(question);
        }

        // GET: Questions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Question question = OnlineTestSystemApp.Test.GetAllQuestionDetails(id.Value);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // POST: Questions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "QuestionNumber,EmailId,QuestionText,Option1,Option2,Option3,Option4,CorrectOption,MarkedOption,isAnsweredCorrect,CreatedDate")] Question question)
        {
            if (ModelState.IsValid)
            {
               
                return RedirectToAction("Index");
            }
            return View(question);
        }

        // GET: Questions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Question question = db.Questions.Find(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // POST: Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Question question = db.Questions.Find(id);
            db.Questions.Remove(question);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
