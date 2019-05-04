using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using bookmanage.Models;

namespace bookmanage.Controllers
{
    public class HomeController : Controller
    {
        BookDataEntities db = new BookDataEntities();
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult dbdata()
        {
            var bookdata = db.BookData.OrderBy(m => m.BOOK_ID).ToList();
            return View(bookdata);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BookData CbookData)
        {
            db.BookData.Add(CbookData);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int BOOK_ID)
        {
            var bookdata = db.BookData.Where(m => m.BOOK_ID == BOOK_ID).FirstOrDefault();
            db.BookData.Remove(bookdata);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int BOOK_ID)
        {
            var bookdata = db.BookData.Where(m => m.BOOK_ID == BOOK_ID).FirstOrDefault();
            return View(bookdata);

        }


        [HttpPost]
        public ActionResult Edit(BookData EbookData)
        {
            int BOOK_ID = EbookData.BOOK_ID;
            var bookdata = db.BookData.Where(m => m.BOOK_ID == BOOK_ID).FirstOrDefault();
            bookdata.BOOK_AUTHOR = EbookData.BOOK_AUTHOR;
            bookdata.BOOK_BOUGHT_DATE = EbookData.BOOK_BOUGHT_DATE;
            bookdata.BOOK_CLASS_ID = EbookData.BOOK_CLASS_ID;
            bookdata.BOOK_KEEPER = EbookData.BOOK_KEEPER;
            bookdata.BOOK_NAME = EbookData.BOOK_NAME;
            bookdata.BOOK_NOTE = EbookData.BOOK_NOTE;
            bookdata.BOOK_PUBLISHER = EbookData.BOOK_PUBLISHER;
            bookdata.BOOK_STATUS = EbookData.BOOK_STATUS;
            bookdata.CREATE_DATE = EbookData.CREATE_DATE;
            bookdata.CREATE_USER = EbookData.CREATE_USER;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}