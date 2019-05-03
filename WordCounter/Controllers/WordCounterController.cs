using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordsController : Controller
  {

    [HttpGet("/words")]
    public ActionResult Index()
    {
      List<Words> allWords = Words.GetAll();
      return View(allWords);

    }

    [HttpGet("/words/repeat")]
    public ActionResult RepeatCounter(string userWord, string userSentence)
    {
      return RepeatCounter(userWord, userSentence);
    }

    [HttpGet("/words/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/words")]
    public ActionResult Create(string userWord, string userSentence)
    {
      Words myWords = new Words(userWord, userSentence);
      return RedirectToAction("Index");
    }
    // [HttpPost("/items/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Words.ClearAll();
    //   return View();
    // }
    //
    [HttpGet("/words/{id}")]
    public ActionResult Show(int id)
    {
      Words words = Words.Find(id);
      return View(words);
    }
  }
}
