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
            int BOOK_ID = EbookData.BookId;
            var bookdata = db.BookData.Where(m => m.BOOK_ID == BOOK_ID).FirstOrDefault();
            bookdata.BOOK_AUTHOR = EbookData.BookAuthor;
            bookdata.BOOK_BOUGHT_DATE = EbookData.BookBoughtDate;
            bookdata.BOOK_CLASS_ID = EbookData.BookClassId;
            bookdata.BOOK_KEEPER = EbookData.BookKeeper;
            bookdata.BOOK_NAME = EbookData.BookName;
            bookdata.BOOK_NOTE = EbookData.BookNote;
            bookdata.BOOK_PUBLISHER = EbookData.BookPublisher;
            bookdata.BOOK_STATUS = EbookData.BookStatus;
            bookdata.CREATE_DATE = EbookData.CreateDate;
            bookdata.CREATE_USER = EbookData.CreateUser;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}