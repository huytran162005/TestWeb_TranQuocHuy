using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestWeb_TranQuocHuy.Models;

namespace TestWeb_TranQuocHuy.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _db;

        public BookController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var books = _db.books.ToList();
            return View(books);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book); 
            }

            _db.books.Add(book);
            _db.SaveChanges();
            TempData["success"] = "Thêm sách mới thành công";
            return RedirectToAction("Index");
        }

        
        public IActionResult Update(int id)
        {
            var book = _db.books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        public IActionResult Update(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            var existBook = _db.books.Find(book.Id);
            if (existBook == null)
            {
                return NotFound();
            }

            existBook.Title = book.Title;
            existBook.Author = book.Author;
            existBook.Price = book.Price;
            existBook.Quantilty = book.Quantilty;

            _db.SaveChanges();
            TempData["success"] = "Cập nhật sách thành công";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var book = _db.books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        public IActionResult Delete(Book student)
        {
            var existStudent = _db.books.Find(student.Id);
            if (existStudent == null)
            {
                return NotFound();
            }
            _db.books.Remove(existStudent);
            _db.SaveChanges();
            TempData["success"] = "Xoá sách thành công";
            return RedirectToAction("Index");
        }
    }
}
