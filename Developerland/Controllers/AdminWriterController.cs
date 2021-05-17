using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Developerland.Controllers
{
    public class AdminWriterController : Controller
    {
        // GET: AdminWriter
        WriterManager wM = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var writerValues = wM.GetList();
            return View(writerValues);
        }

        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer writer)
        {
            WriterValidator wV = new WriterValidator();
            ValidationResult results = wV.Validate(writer);
            if (results.IsValid)
            {
                wM.WriterAdd(writer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}