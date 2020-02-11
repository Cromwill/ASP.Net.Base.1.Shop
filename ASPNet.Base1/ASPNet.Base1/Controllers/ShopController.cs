using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNet.Base1.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult StoryPage()
        {

            return View();
        }

        public ActionResult ProductPage()
        {
            return View();
        }

    }
}