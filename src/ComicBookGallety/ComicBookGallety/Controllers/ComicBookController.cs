﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallety.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday){


                return Redirect("/");
            }
            return new ContentResult()
            {
                Content = "Hello from the comic books controller!"
            };
        }

    };


}