using NguyenTienLong_1811060449_lab06.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenTienLong_1811060449_lab06.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ListBook()
        {
            BookManagerContext context = new BookManagerContext();
            var listBook = context.books.ToList();
            return View(listBook);
        }
        [Authorize]
        public ActionResult BuyBook(int id)
        {
            BookManagerContext context = new BookManagerContext();
            book book = context.books.SingleOrDefault(p => p.ID == id);
                if(book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost,ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(book input)
        {
            //Sử dụng context để làm việc với các class
            BookManagerContext context = new BookManagerContext();
            //1. Lấy tất toàn bộ thông tin sách từ bảng Book
            List<book> listBook = context.books.ToList();
            //3. Insert một đối tượng Book b vào database
            context.books.Add(input); //Add or Update Book b
            context.SaveChanges();
            return View("ListBook", context.books.ToList());
        }

        public ActionResult Edit(int id)
        {
            BookManagerContext context = new BookManagerContext();
            book book = context.books.FirstOrDefault(p => p.ID == id);
            return View(book);
        }

        [HttpPost,ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(book book)
        {

            //Sử dụng context để làm việc với các class
            BookManagerContext context = new BookManagerContext();

            book dbUpdate = context.books.FirstOrDefault(p => p.ID == book.ID);
            if (dbUpdate != null)
            {
                context.books.AddOrUpdate(dbUpdate); 
                context.SaveChanges();
            }

            return View("ListBook", context.books.ToList());
        }

        public ActionResult Delete(int id)
        {
            BookManagerContext context = new BookManagerContext();
            book book = context.books.FirstOrDefault(p => p.ID == id);
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(book book)
        {

            //Sử dụng context để làm việc với các class
            BookManagerContext context = new BookManagerContext();

            book dbUpdate = context.books.FirstOrDefault(p => p.ID == book.ID);
            if (dbUpdate != null)
            {
                context.books.Remove(dbUpdate);
                context.SaveChanges();

            }

            return View("ListBook", context.books.ToList());
        }
    }
}