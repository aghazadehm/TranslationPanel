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
        static List<TranslateViewModel> tl;
        public TranslationsController()
        {
        }
        public IActionResult Index()
        {
           tl = new List<TranslateViewModel>();
            var langs = new Dictionary<string, string>();
            langs.Add("En", "");
            langs.Add("Ar", "");
            tl.Add(new TranslateViewModel() { ID = 1, Name = "رضا", Language = "Ar", Translation = "" });
            tl.Add(new TranslateViewModel() { ID = 3, Name = "محمد", Language = "Ar", Translation = "" });
            tl.Add(new TranslateViewModel() { ID = 2, Name = "فرهاد", Language = "Ar", Translation = "" });
            ViewData["langNames"] = new List<string> { "English", "العربی" };
            return View(tl);
        }

        [HttpPost]
        public IActionResult SaveTranslate(int id, string lang, string value)
        {
            var item = tl.Find(x => x.ID == id);
            item.Translation = value;
            ViewData["langNames"] = new List<string> { "English", "العربی" };
            return View("index", tl);
        }
    }
}