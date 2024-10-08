using Balta.ContentContext.Enums;

namespace Balta.ContentContext

{
    public class Lecture
    {
        public int Order { get; set; } //ordem das aulas

        public string  Title { get; set; }
        public int DurationInMinutes {get; set;}
        public EContentLevel Level {get; set;}
    }
}