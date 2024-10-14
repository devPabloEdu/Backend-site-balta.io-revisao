using System;
using Balta.NotificationContext;

namespace Balta.ContentContext
{
    public class Base : Notifiable
     {
        public Base()
        {
            Id = Guid.NewGuid(); //SPOF - PONTO UNICO DE FALH
        }

        public Guid Id { get; set; }
        
    }
}