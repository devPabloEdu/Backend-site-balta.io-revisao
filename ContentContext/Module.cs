using System.Collections.Generic;
using Balta.SharedContext;

namespace Balta.ContentContext
{
 public class Module : Base
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