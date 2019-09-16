using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiApp.Models;
using System.Data.Entity;

namespace WebApiApp.Controllers
{
    public class ValuesController : ApiController
    {
        BookContext db = new BookContext();

        public IEnumerable<Book> GetBook()
        {
            return db.Books;
        }

        public Book GetBook(int id)
        {
            Book book = db.Books.Find(id);
            return book;
        }

        [HttpPost]
        public void CreateBook([FromBody]Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        [HttpPut]
        public void EditBook(int id, [FromBody]Book book)
        {
            if(id == book.Id)
            {
                db.Entry(book).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            Book book = db.Books.Find(id);

            if(book != null)
            {
                db.Books.Remove(book);

                db.SaveChanges();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
