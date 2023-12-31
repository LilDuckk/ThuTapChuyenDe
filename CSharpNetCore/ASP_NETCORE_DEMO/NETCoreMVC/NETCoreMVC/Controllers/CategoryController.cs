﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nest;
using NETcoreWebMVC.Models;

namespace NETcoreWebMVC.Controllers
{
    public class CategoryController : Controller
    {
        public static List<Category> _context = Datalocal._categories;
        // GET: CategoryController
        public ActionResult Index()
        {
            /*var model = _context.ToList();*/
            return View(_context);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var data = Datalocal._categories.FirstOrDefault(x => x.Id == id);
            return View(data);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            var Id = Datalocal._categories.MaxBy(x => x.Id).Id;
            ViewBag.Id = Id + 1;
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                //Cập nhật giá trị cho các cột ẩn
                category.CreateDate = DateTime.Now;
                category.CreateBy = "Chung Trinh";
                //Thêm đối tượng category vào _categories trong Datalocal
                Datalocal._categories.Add(category);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Datalocal._categories.FirstOrDefault(x => x.Id == id);
            return View(data);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
                //Cập nhật dữ liệu trong datalocal
                for (int i = 0; i < Datalocal._categories.Count; i++)
                {
                    if (Datalocal._categories[i].Id == id)
                    {
                        Datalocal._categories[i] = category;
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Datalocal._categories.FirstOrDefault(x=>x.Id == id);
            return View(data);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category category)
        {
            try
            {
                foreach (var item in Datalocal._categories)
                {
                    if(item.Id == id)
                    {
                        Datalocal._categories.Remove(item);
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
