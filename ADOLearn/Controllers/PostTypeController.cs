using ADOLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADOLearn.Controllers
{
    public class PostTypeController : Controller
    {
        // GET: PostType
        public ActionResult List()
        {
            ASPLearnEntities2 db = new ASPLearnEntities2();
            List<PostType> posttypes = db.PostTypes.ToList();
            return View(posttypes);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(PostType postType)
        {
            if(string.IsNullOrEmpty(postType.Name)==true)
            {
                ModelState.AddModelError("", "Thiếu thông tin loại bài viết");
                return View(postType);
            }
            ASPLearnEntities2 db = new ASPLearnEntities2();
            try
            {
                db.PostTypes.Add(postType);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            catch(Exception ex) {
                ModelState.AddModelError("", "Thiếu thông tin loại bài viết");
                return View(postType);
            }
            return View();
        }

        public ActionResult Update(int id)
        {
            ASPLearnEntities2 db = new ASPLearnEntities2();
            var model=db.PostTypes.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(PostType model)
        {
            if (string.IsNullOrEmpty(model.Name) == true)
            {
                ModelState.AddModelError("", "Thiếu thông tin loại bài viết");
                return View(model);
            }
            ASPLearnEntities2 db = new ASPLearnEntities2();
            var updateModel=db.PostTypes.Find(model.Id);
            try
            {
                updateModel.Name = model.Name;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(model);
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            ASPLearnEntities2 db = new ASPLearnEntities2();
            var model = db.PostTypes.Find(id);
            db.PostTypes.Remove(model);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}