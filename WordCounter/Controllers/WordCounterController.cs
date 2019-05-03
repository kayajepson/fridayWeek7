using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {

    // [HttpGet("/words")]
    // public ActionResult Index()
    // {
    //   // List<Words> allWords = Words.GetAll();
    //   // return View(allWords);
    // }

    [HttpGet("/words/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/words/show")]
    public ActionResult Show()
    {
      return View();
    }

    // [HttpPost("/words")]
    // public ActionResult Create(string userWord, string userSentence)
    // {
    //   // Words myWords = new Words(cityName, date, journal, companion);
    //   // return RedirectToAction("Index");
    // }
    // [HttpPost("/items/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Words.ClearAll();
    //   return View();
    // }
    //
    // [HttpGet("/words/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Words words = Words.Find(id);
    //   return View(words);
    // }
  }
}
