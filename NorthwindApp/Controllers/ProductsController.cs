using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using NorthwindApp.Domain.Repositories;

namespace NorthwindApp.Controllers
{
    public class ProductsController : Controller
    {

        public ProductsController(IProductRepository productRepository, 
            ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;

        //
        // GET: /Products/

        public ActionResult Index()
        {
            var entities = _productRepository.GetAll();
            return View(entities);
        }

        //
        // GET: /Products/Details/5

        public ActionResult Details(int id)
        {
            var entity = _productRepository.GetById(id);
            return View(entity);
        }

        //
        // GET: /Products/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View(
                new Models.EditProductViewModel()
                {
                    Product = new Domain.Product(),
                    Categories = _categoryRepository.GetAll()
                });
        }

        //
        // POST: /Products/Create

        [Authorize(Roles = "Admin")]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken()]
        public ActionResult Create(
            [Bind(Prefix = "Product")]Domain.Product entity)
        {
            if (!ModelState.IsValid)
                return View(
                    new Models.EditProductViewModel()
                    {
                        Product = entity,
                        Categories = _categoryRepository.GetAll()
                    });
            _productRepository.Create(entity);
            return RedirectToAction("Index");
        }

        //
        // GET: /Products/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            return View(
                new Models.EditProductViewModel()
                {
                    Product = _productRepository.GetById(id),
                    Categories = _categoryRepository.GetAll()
                });
        }

        //
        // POST: /Products/Edit/5

        [Authorize(Roles = "Admin")]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken()]
        public ActionResult Edit([Bind(Prefix = "Product")]Domain.Product entity)
        {            
            if (!ModelState.IsValid)
                return View(
                    new Models.EditProductViewModel()
                    {
                        Product = entity,
                        Categories = _categoryRepository.GetAll()
                    });
            _productRepository.Update(entity);
            return RedirectToAction("Index");
        }

        [Authorize(Roles="Admin")]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken()]
        public ActionResult Delete(int id)
        {
            try
            {
                _productRepository.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }


    }
}
