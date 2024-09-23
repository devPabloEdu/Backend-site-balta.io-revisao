namespace Balta.ContentContext 
{
    public abstract class Content
    { 
        public Content()
        {
            Id = Guid.NewGuid(); //SPOF - PONTO UNICO DE FALHA
        }
        public Guid Id { get; set; } //mudei de int para um Guid
        public string Title { get; set; }

        public string Url { get; set; }

    }
}