using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using NorthwindApp.Domain.Repositories;

namespace NorthwindApp.Controllers
{
    public class CategoriesController : Controller
    {
        
        public CategoriesController(
            Domain.Repositories.ICategoryRepository repository)
        {
            _repository = repository;
        }

        private ICategoryRepository _repository;

        //
        // GET: /Categories/
        
        public ActionResult Index()
        {
            var categories = _repository.GetAll();
            return View(categories);
        }


        //
        // GET: /Categories/Details/5

        public ActionResult Details(int id)
        {
            var entity = _repository.GetById(id);
            return View(entity);
        }

        //
        // GET: /Categories/Create

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View(new Domain.Category());
        }

        //
        // POST: /Categories/Create
        [Authorize(Roles = "Admin")]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken()]
        public ActionResult Create(Domain.Category entity)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(entity);
                _repository.Create(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(entity);
            }
        }

        //
        // GET: /Categories/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            var entity = _repository.GetById(id);
            return View(entity);
        }

        //
        // POST: /Categories/Edit/5
        [Authorize(Roles = "Admin")]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken()]
        public ActionResult Edit(Domain.Category entity)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(entity);
                _repository.Update(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(entity);
            }
        }

        [Authorize(Roles = "Admin")]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken()]
        public ActionResult Delete(int id)
        {
            try
            {                
                _repository.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

    }
}
