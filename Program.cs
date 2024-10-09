using System;
using Balta.ContentContext;
using System.Collections.Generic;
using System.Linq;

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

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos - oop");
            var courseCSHARP = new Course("Fundamentos c#", "fundamentos - c#");
            var courseASPNET = new Course("Fundamentos .Net", "fundamentos - .Net");
            courses.Add(courseOOP);
            courses.Add(courseCSHARP);
            courses.Add(courseASPNET);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-.net");
            var careerItem2 = new CareerItem(2, "Aprenda .NET", "", courseOOP);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCSHARP);
            var careerItem3 = new CareerItem(3, "Aprenda C#", "", courseASPNET);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x=>x.Order))
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);
                    Console.WriteLine("------------------");
                    
                }
            }
        }
    }
}
