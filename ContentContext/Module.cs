using System.Collections.Generic;
namespace Balta.ContentContext
{
 public class Module
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }//ordem do modulo, tipo modulo 1, modulo 2 e etc.
        public string  Title { get; set; }

        public IList<Lecture> Lectures {get; set;}

    }
}