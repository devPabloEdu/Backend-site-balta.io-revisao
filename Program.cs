using System;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var cursoDeCsharp = new Course();
            Console.WriteLine(cursoDeCsharp.Id);
        }
    }
}
