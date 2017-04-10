using ComicBookGallety.Data;
using ComicBookGallety.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallety.Controllers
{
    public class ComicBookController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;
       

        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
             var comicBook = _comicBookRepository.GetComicBook(id.Value);
            return View(comicBook);
        }
        public ActionResult Index()
        {
            var comicBookList = _comicBookRepository.GetComicBooks();

            return View(comicBookList);
        }

};


}
