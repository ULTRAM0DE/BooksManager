using BooksManager.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManager.View.ModelView
{
    class ViewBooks
    {
        public DB.Books Books { get; set; }
        public string Name { get; set; }
        public string Price  { get; set; }
        public string cena { get; set; }

        public string Store { get; set; }
       

        public int count { get; set; }



        public ViewBooks(DB.Books books)
        {
            Books = books;
            Name = $"{books.Name} | {books.Name}";
            Price = $"{books.price}";      
        }

        /*private string GetOpisanie(Books books)
        {
            try
            {
                DB.GGWPEntities1 entities1 = new DB.GGWPEntities1();
                var s = entities1.Books.Where(x => x.Id == books.Id).Sum(x => x.price);
                count = (int)s;
                return Price;
             
            }
            catch
            {
                throw new Exception("Ошибка");
            }
        }*/
 
    }
}
