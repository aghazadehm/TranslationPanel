using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Presentation.WebApp.Models;

namespace Presentation.WebApp.Controllers
{
    public class TranslationsController : BaseController
    {
        static List<TranslatorViewModel> tl;
        public TranslationsController()
        {

        }
        public IActionResult Index()
        {
            ViewBag.ActiveType = 3;
            tl = new List<TranslatorViewModel>();
            var langs = new Dictionary<string, string>();
            langs.Add("En", "");
            langs.Add("Ar", "");
            tl.Add(new TranslatorViewModel() { Id = 101, PhraseId = 1, PhraseText = "رضا", PhraseTypeName = "commodity", LanguageAbbr = "Ar", Translation = "" });
            tl.Add(new TranslatorViewModel() { Id = 303, PhraseId = 2, PhraseText = "محمد", PhraseTypeName = "commodity", LanguageAbbr = "Ar", Translation = "" });
            tl.Add(new TranslatorViewModel() { Id = 202, PhraseId = 3, PhraseText = "فرهاد", PhraseTypeName = "commodity", LanguageAbbr = "Ar", Translation = "" });
            ViewData["langNames"] = new List<string> { "English", "العربی" };
            return View(tl);
        }

        public IActionResult GetPhrases(int phraseTypeId, int languageId=0)
        {
            ViewBag.phraseTypeId = phraseTypeId;
            ViewBag.LanguageId = languageId;
            tl = new List<TranslatorViewModel>();
            var langs = new Dictionary<string, string>();
            langs.Add("En", "");
            langs.Add("Ar", "");
            tl.Add(new TranslatorViewModel() { Id = 101, PhraseId = 1, PhraseText = "رضا", PhraseTypeName = "commodity", LanguageAbbr = "Ar", Translation = "" });
            tl.Add(new TranslatorViewModel() { Id = 303, PhraseId = 2, PhraseText = "محمد", PhraseTypeName = "commodity", LanguageAbbr = "Ar", Translation = "" });
            tl.Add(new TranslatorViewModel() { Id = 202, PhraseId = 3, PhraseText = "فرهاد", PhraseTypeName = "commodity", LanguageAbbr = "Ar", Translation = "" });
            ViewData["langNames"] = new List<string> { "English", "العربی" };
            return View("index", tl);
        }

        [HttpPost]
        public IActionResult SaveTranslate(int id, string lang, string value)
        {
            var item = tl.Find(x => x.Id == id);
            item.Translation = value;
            ViewData["langNames"] = new List<string> { "English", "العربی" };
            return View("index", tl);
        }
    }
}