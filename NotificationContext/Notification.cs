namespace Balta.NotificationContext
{
    public sealed class Notification
    {
        public Notification()
        {
            
        }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; set; } //propriedade q apresenta o erro
        public string Message { get; set; } //mensagem do erro
    }
}