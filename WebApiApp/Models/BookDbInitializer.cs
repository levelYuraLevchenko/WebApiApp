using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApiApp.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "n1", Author = "a1", Year = 1111 });
            db.Books.Add(new Book { Name = "n2", Author = "a2", Year = 2222 });
            db.Books.Add(new Book { Name = "n3", Author = "a3", Year = 3333 });

            base.Seed(db);
        }
    }
}