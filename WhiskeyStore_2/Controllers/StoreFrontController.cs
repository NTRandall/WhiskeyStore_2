using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WhiskeyStore_2.DAL;
using WhiskeyStore_2.Models;

namespace WhiskeyStore_2.Controllers
{
    public class StoreFrontController : Controller
    {
        private WhiskeyStoreContext db = new WhiskeyStoreContext();
        // GET: StoreFront
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }

            return View(category);
        }

    }
}