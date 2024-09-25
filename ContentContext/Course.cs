using System.Collections;
using Balta.ContentContext.Enums;

namespace Balta.ContentContext 
{
    public class Course : Content
    { 
        public Course(string title, string url)
        :base(title, url)
        {
            Modules = new List<Module>();
        }
        public string  Tag { get; set; } //tags de cursos, como o 2802, 784 e por ai vai, é diferente do id
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes {get; set;}
        public EContentLevel Level {get; set;}
    }
}