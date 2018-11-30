using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WorCounterController : Controller
  {
    [HttpGet("/wordCounter")]
    public ActionResult Index()
    {

      return View();
    }
    [HttpGet("/wordCounter/new")]
    public ActionResult new()
    {

      return View();
    }
    [HttpPost("/wordCounter")]
    public ActionResult Create(string inputWord, string inputstring)
    {
    WordFinder newWordFinder = new WordFinder(inputWord, inputstring);
    return RedirectToAction("Index");
    }

  }

}
}
