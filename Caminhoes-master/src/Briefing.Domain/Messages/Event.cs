using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace caminhoes.Domain.Messages
{
    public class Event : Message, INotification
    {
        public Event()
        {
            Timestamp = DateTime.Now;

        }
        public DateTime Timestamp { get; private set; }
    }
}
