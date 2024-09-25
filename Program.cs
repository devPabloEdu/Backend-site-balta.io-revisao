using System;
using Balta.ContentContext;
using System.Collections.Generic;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var articles  = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "Orientação - obj"));
            articles.Add(new Article("Artigo sobre C#", "Orientação - c#"));
            articles.Add(new Article("Artigo sobre .Net", "Orientação - .Net"));

            foreach(var article in articles)
            {
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Url);
                Console.WriteLine("-----------");
            }

        }
    }
}
