using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordCounter")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpGet("/wordCounter/new")]
    public ActionResult New()
    {

      return View();
    }
    [HttpPost("/wordCounter")]
    public ActionResult Create(string inputWord, string inputString, List<string> newResult, List<int> newCount)
    {

      WordFinder newWordFinder = new WordFinder(inputWord, inputString, newResult, newCount);

      return View("Index" ,newWordFinder);
    }

  }


}
