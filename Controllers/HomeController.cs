using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
using sellyourcar.Data;
using sellyourcar.Models;
namespace sellyourcar.Controllers;

using System.Linq;




public class HomeController : Controller
{


    private readonly ApplicationDbContext _db;

    public HomeController(ApplicationDbContext db)
    {
        _db = db;
    }



    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Sellcar()

    {
        List<DatabaseViewModel> entries = _db.DatabaseViewModel.ToList();
        return View(entries);
    }


    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(DatabaseViewModel objects)
    {
        if (objects != null && objects.Title.Length < 3)
        {
            ModelState.AddModelError("Title", "Title too short");
        }
        if (ModelState.IsValid)
        {
            _db.DatabaseViewModel.Add(objects);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(objects);

    }

    [HttpGet]
    public IActionResult Edit(int? id)

    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        DatabaseViewModel? editEntry = _db.DatabaseViewModel.Find(id);

        if (editEntry == null)
        {
            return NotFound();
        }

        return View(editEntry);

    }


    [HttpPost]
    public IActionResult Edit(DatabaseViewModel objects)
    {
        if (objects != null && objects.Title.Length < 3)
        {
            ModelState.AddModelError("Title", "Title too short");
        }
        if (ModelState.IsValid)
        {
            _db.DatabaseViewModel.Update(objects);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(objects);

    }




    public IActionResult Delete(int? id)

    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        DatabaseViewModel? editEntry = _db.DatabaseViewModel.Find(id);

        if (editEntry == null)
        {
            return NotFound();
        }

        return View(editEntry);

    }

    [HttpPost]
    public IActionResult Delete(DatabaseViewModel objects)
    {


        _db.DatabaseViewModel.Remove(objects);
        _db.SaveChanges();
        return RedirectToAction("Index");



    }







    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]


    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}















