using ADOLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace ADOLearn.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult List()
        {
            ASPLearnEntities2 db = new ASPLearnEntities2();
            List<Post> posts = db.Posts.ToList();
            return View(posts);
        }

        public ActionResult Add()
        {
            return View(new Post());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add(Post model) {
            ASPLearnEntities2 db = new ASPLearnEntities2();
            if(string.IsNullOrEmpty(model.PostName)) {
                ModelState.AddModelError("", "Thiếu tên bài viết");
                return View(model);
            }
            db.Posts.Add(model);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Edit(int id)
        {
            ASPLearnEntities2 db = new ASPLearnEntities2();
            var post = db.Posts.Find(id);
            return View(post);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Post model)
        {
            ASPLearnEntities2 db = new ASPLearnEntities2();
            var post = db.Posts.Find(model.Id);
            post.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}