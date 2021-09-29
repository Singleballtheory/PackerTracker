using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class BackpacksController : Controller
  {

    [HttpGet("/backpacks")]
    public ActionResult Index()
    {
      List<Backpack> allBackpacks = Backpack.GetAll();
      return View(allBackpacks);
    }

    [HttpGet("/backpacks/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/backpacks")]
    public ActionResult Create(string thing)
    {
      Backpack myBackpack = new Backpack(thing);
      return RedirectToAction("Index");
    }

    [HttpGet("/backpacks/delete")]
    public ActionResult DeleteAll()
    {
      Backpack.ClearAll();
      return View();
    }

    [HttpPost("/backpacks/delete/{id}")]
    public ActionResult DeleteById(int id)
    {
      Backpack.RemoveById(id);
      return RedirectToAction("Index");
    }

    [HttpGet("/backpacks/{id}")]
    public ActionResult Show(int id)
    {
      Backpack foundBackpack = Backpack.Find(id);
      return View(foundBackpack);
    }

  }
}