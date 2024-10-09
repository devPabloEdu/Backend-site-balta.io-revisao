namespace Balta.ContentContext{
    public class CareerItem
     {
        public CareerItem(int order, string title, string description, Course course)
        {
            if (course == null)
            {
                throw new System.Exception("O curso nao pode ser nulo");
            }
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; } //ordem deste item
        public string Title { get; set; } //titulo
        public string Description { get; set; } //descrição do curso/carreira

        public Course Course {get; set;}
     }
}