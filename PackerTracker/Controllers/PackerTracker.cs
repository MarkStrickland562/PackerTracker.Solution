using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class PackerTrackerController : Controller
  {

    [HttpGet("/packertracker")]
    public ActionResult Index()
    {
      List<Tracker> allpackertracker = Tracker.GetAll();
      return View(allpackertracker);
    }

    [HttpGet("/packertracker/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/packertracker")]
    public ActionResult Create(string myItemName, int myPrice, int myWeigth, bool myPurchased, string myManufacturer, bool myPacked)
    {
      Tracker myPackerTracker = new Tracker(myItemName, myPrice, myWeigth, myPurchased, myManufacturer, myPacked);
      return RedirectToAction("Index");
    }

    [HttpPost("/packertracker/{id}")]
    public ActionResult Update(int id)
    {
      Tracker myPackerTracker = Tracker.Find(id);
      myPackerTracker.SetPacked(true);
      return RedirectToAction("Index");
    }

    [HttpGet("/packertracker/{id}")]
    public ActionResult Show(int id)
    {
      Tracker tracker = Tracker.Find(id);
      return View(tracker);
    }

  }
}
