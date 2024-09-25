namespace Balta.ContentContext{
    public class CareerItem
     {
        public int Order { get; set; } //ordem deste item
        public string Title { get; set; } //titulo
        public string Description { get; set; } //descrição do curso/carreira

        public Course Course {get; set;}
     }
}