using Balta.NotificationContext;

namespace Balta.ContentContext{
    public class CareerItem : Base
     {
        public CareerItem(int order, string title, string description, Course course)
        {
            if (course == null)
            {
               AddNotification(new Notification("Course", "Curso invalido!"));
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