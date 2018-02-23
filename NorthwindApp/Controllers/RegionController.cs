//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Mvc.Ajax;
//using NorthwindApp.Domain.Repositories;

//namespace NorthwindApp.Controllers
//{
//    public class RegionController : Controller
//    {
    
//        public RegionController(IRegionRepository repository)
//        {
//            _repository = repository;
//        }
		
//        private IRegionRepository _repository;
    
//        //
//        // GET: /Region/

//        public ActionResult Index()
//        {
//            var entities = _repository.GetAll();
//            return View(entities);
//        }

//        //
//        // GET: /Region/Details/5

//        public ActionResult Details(int id)
//        {
//            var entity = _repository.GetById(id);
//            return View(entity);
//        }

//        //
//        // GET: /Region/Create

//        public ActionResult Create()
//        {
//            return View(new Domain.Region());
//        } 

//        //
//        // POST: /Region/Create

//        [AcceptVerbs(HttpVerbs.Post)]
//        [ValidateAntiForgeryToken()]
//        public ActionResult Create(Domain.Region entity)
//        {
//            try
//            {
//                if (!ModelState.IsValid)
//                    return View(entity);
//                _repository.Create(entity);
//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View(entity);
//            }
//        }

//        //
//        // GET: /Region/Edit/5
 
//        public ActionResult Edit(int id)
//        {
//            var entity = _repository.GetById(id);
//            return View(entity);
//        }

//        //
//        // POST: /Region/Edit/5

//        [AcceptVerbs(HttpVerbs.Post)]
//        [ValidateAntiForgeryToken()]
//        public ActionResult Edit(Domain.Region entity)
//        {
//            try
//            {
//                if (!ModelState.IsValid)
//                    return View(entity);
//                _repository.Update(entity);
//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View(entity);
//            }
//        }
        
//        [AcceptVerbs(HttpVerbs.Post)]
//        [ValidateAntiForgeryToken()]
//        public ActionResult Delete(int id)
//        {
//            try
//            {                
//                _repository.Delete(id);
//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View("Index");
//            }
//        }

        
//    }
//}
