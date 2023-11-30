using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NETcoreWebMVC.Models;

namespace NETCoreMVC.Controllers
{
    public class ProductsController : Controller
    {
        public static List<Product> _context = Datalocal._products;
        // GET: ProductsController
        public ActionResult Index()
        {
            return View(_context);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            var Id = Datalocal._products.MaxBy(x => x.Id).Id;
            ViewBag.Id = Id + 1;
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                Datalocal._products.Add(product);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
