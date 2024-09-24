using System.Collections;

namespace Balta.ContentContext 
{
    public class Course : Content
    { 
        public Course()
        {
            Modules = new List<Module>();
        }
        public string  Tag { get; set; } //tags de cursos, como o 2802, 784 e por ai vai, é diferente do id
        public IList<Module> Modules { get; set; }
    }

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

    public class Lecture
    {
        public int Order { get; set; } //ordem das aulas

        public string  Title { get; set; }
    }
}