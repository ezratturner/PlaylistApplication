using CattyWebApp.Data;
using CattyWebLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CattyWebLibrary.Models.Binding;

namespace CattyWebApp.Controllers
{
    [Route("[Controller]")]
    public class CatsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public CatsController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }
        //READ
        [Route("")]
        public IActionResult Index()
        {
            var allCats = dbContext.Cats.ToList();
            return View(allCats);
        }
        [Route("details/{id:int}")]  //go to the details controller and get the cats with this ID, the ID is an integer
        public IActionResult Details(int id)
        {
            var catById = dbContext.Cats.FirstOrDefault(c => c.ID == id); 
            return View(catById); //getting the first cat that has this ID
        }

        //CREATE
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("create")] //http post is passing data to a particular place
        public IActionResult Create(AddCatBindingModel bindingModel)
        {
            var catToCreate = new Cat //creating things! this created your first cat sammy!
            {
                Name = bindingModel.Name,
                Age = bindingModel.Age,
                Size = bindingModel.Size,
                Color = bindingModel.Color,
                PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                CreatedAt = DateTime.Now
            };
            dbContext.Cats.Add(catToCreate); //adding it to the cats table
            dbContext.SaveChanges(); // save changes
            return RedirectToAction("Index"); // then redirect to one cat
        }

        //KITTEN SECTION
        //CREATE
        [Route("addkitten/{catID:int}")] //placeholder controller
        public IActionResult CreateKitten(int catID)
        {
            var cat = dbContext.Cats.FirstOrDefault(c => c.ID == catID); //where the id matches the cat id and return name property
            ViewBag.CatName = cat.Name;
            return View();
        }
        [HttpPost]
        [Route("addkitten/{catID:int}")]
        public IActionResult CreateKitten(AddKittenBindingModel bindingModel, int catID)
        {
            bindingModel.CatID = catID;
            var kittenToCreate = new Kitten
            {
                Name = bindingModel.Name,
                Age = bindingModel.Age,
                Size = bindingModel.Size,
                Cat = dbContext.Cats.FirstOrDefault(c => c.ID == catID),
                Color = bindingModel.Color,
                PictureURL = "https://th.bing.com/th/id/R80677ad4549c7ab35bc3e3cca9f5fa4e?rik=nlG0uuKC%2fVgkDg&pid=ImgRaw",
                CreatedAt = DateTime.Now
            };
            dbContext.Kittens.Add(kittenToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("{id:int}/kittens")]
        public IActionResult ViewKittens(int id)
        {
            var cat = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            var kittens = dbContext.Kittens.Where(c => c.Cat.ID == id).ToList();
            ViewBag.CatName = cat.Name;
            return View(kittens);
        }
        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var catById = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            return View(catById);
        }
        [HttpPost] //because this is modifying information
        [Route("update/{id:int}")]
        public IActionResult Update(Cat cat, int id)
        {
            var catToUpdate = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            catToUpdate.Name = cat.Name;
            catToUpdate.Age = cat.Age;
            catToUpdate.PictureURL = cat.PictureURL;
            catToUpdate.Size = cat.Size;
            catToUpdate.Color = cat.Color;
            dbContext.SaveChanges(); //we have assigned values
            return RedirectToAction("Index"); //redirecting back to the cats homepage
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var catToDelete = dbContext.Cats.FirstOrDefault(c => c.ID == id);
            dbContext.Cats.Remove(catToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}