using System;

namespace caminhoes.Domain.Messages
{
    public abstract class Message
    {
        public Message()
        {
            MessageType = GetType().Name;
        }

        public string MessageType { get; protected set; }
        public Guid AggregateRoot { get; set; }
    }
}
