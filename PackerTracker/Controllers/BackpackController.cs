using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {

    // [HttpGet("/items")]
    // public ActionResult Index()
    // {
    //   List<Backpack> allBackpacks = Backpack.GetAll();
    //   return View(allBackpacks);
    // }

    // [HttpGet("/backpacks/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }

    // [HttpPost("/backpacks")]
    // public ActionResult Create(string description)
    // {
    //   Backpack myBackpack = new Backpack(description);
    //   return RedirectToAction("Index");
    // }

    // [HttpGet("/backpacks/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Backpack.ClearAll();
    //   return View();
    // }

    // [HttpPost("/Backpacks/delete/{id}")]
    // public ActionResult DeleteById(int id)
    // {
    //   Backpack.RemoveById(id);
    //   return RedirectToAction("Index");
    // }

    // [HttpGet("/Backpacks/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Backpack foundBackpack = Backpack.Find(id);
    //   return View(foundBackpack);
    // }

  }
}