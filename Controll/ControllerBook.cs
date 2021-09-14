using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BooksManager.Controll
{
    internal class ControllerBook
    {
      public static List<View.ModelView.ViewBooks> GetViewBooks()
        {
            try
            {
                DB.GGWPEntities1 entities1 = new DB.GGWPEntities1();
                var books = entities1.Books.ToList();
                List<View.ModelView.ViewBooks> views = new List<View.ModelView.ViewBooks>();

                foreach(var item in books)
                {
                    views.Add(new View.ModelView.ViewBooks(item));
                }
                return views;
            }

            catch
            {
                throw new Exception("ошибка БД");
            }
        }

        internal static bool AddBook(string name,string description,string price,string gowardlavcraft,string stivenking,string jorgoryel)
        {
            DB.Books newbooks = new DB.Books();

            try
            {
                newbooks = new DB.Books();

                newbooks.Discription = description;
                newbooks.Id_GowardLavCraft = GetIdGowardLavCraft(gowardlavcraft as string);
                newbooks.Id_StivenKing = GetIdStivenKing(stivenking as string);
                newbooks.Id_JorgOryel = GetIdJorgOryel(jorgoryel as string);
                newbooks.price = Convert.ToInt32(price);



            }
            catch
            {
                throw new Exception("ошибка входных данных");
            }

            if(newbooks == null)
            {
                return false;
            }
           
                DB.GGWPEntities1 entities1 = new DB.GGWPEntities1();
                entities1.Books.Add(newbooks);
                entities1.SaveChanges();
                return true;
            
            
        }



        private static int GetIdJorgOryel(string name)
        {
           
            
                DB.GGWPEntities1 entities1 = new DB.GGWPEntities1();
                return entities1.JorgOryel.Where(x => x.YesOrNo == name).First().Id;
            
            
        }

        private static int? GetIdStivenKing(string name)
        {
            DB.GGWPEntities1 entities1 = new DB.GGWPEntities1();
            return entities1.JorgOryel.Where(x => x.YesOrNo == name).First().Id;
        }

        private static int? GetIdGowardLavCraft(string name)
        {
            DB.GGWPEntities1 entities1 = new DB.GGWPEntities1();
            return entities1.JorgOryel.Where(x => x.YesOrNo == name).First().Id;
        }
    }
}
