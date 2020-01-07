using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
      public ActionResult Template() { return View(); }

      [Route("/second")]//
      public ActionResult Second(string title, string description, string contactInfo) 
      {
          JobOpening newJob = new JobOpening(title, description, contactInfo);
           return View("Second",newJob); }

  }
}