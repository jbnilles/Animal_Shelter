using System;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Controllers
{
  //[HttpPost("/Animals")]
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;
    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Animal> x = _db.Animal.ToList();
     
      return View(x);
    }
    public ActionResult Create()//httpGet
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animal.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult SortByName() //httpGet
    {
      // select * from animal order by Name 
      List<Animal> model = _db.Animal.OrderBy(a => a.Name).ToList();
       


      // select * from animal where Type = Cat
      //List<Animal> model = _db.Animal.Where(a => a.Type == "Cat").ToList();


      return View("Index", model);
    }
    // public ActionResult Test() //httpGet
    // {
    //   List<Animal> model = _db.Animal.OrderBy(a => a.Name).ToList();

    //   List<Animal> our_Animals = Animal.ourAnimals;
    //   string b = Animal.Breed;
    //   Animal a = new Animal(1,"bob","male", "mutt", DateTime.Now, "dog");
      
    //   Animal.FeedAllAnimals(); // static meth
    //   //Animal.FeedThisAnimal(); error

    //   a.FeedThisAnimal(); // not static
    //  // a.FeedAllAnimals(); error
    //   return View("Index");
    // }
  }
}