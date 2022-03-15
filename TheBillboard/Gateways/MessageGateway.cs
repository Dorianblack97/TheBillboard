using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBillboard.Abstract;
using TheBillboard.Models;

namespace TheBillboard.Gateways
{
    public class MessageGateway : IMessageGateway
    {
        private List<Message> messageList;

        public MessageGateway()
        {
            messageList = new();
            messageList.Add(new( "Hello World!", "Prova", "Alberto", DateTime.Now, DateTime.Now, 1));
            messageList.Add(new( "Hello World!1", "Prova2", "Alberto3", DateTime.Now, DateTime.Now, 2));
            messageList.Add(new( "Hello World!2", "Prova5", "Alberto54", DateTime.Now, DateTime.Now, 3));
        }
        public Message GetMessage(int id)
        {
            var message = GetMessages().Single(t => t.Id == id);
            return message;
        }

        public IEnumerable<Message> GetMessages()
        {
            return messageList;
        }

        public void DeleteMessage(int id)
        {
            messageList = messageList.Where(t => t.Id != id).ToList();
        }

        public Message Create(Message message)
        {
            messageList.Add(message);
            return message;
        }
        
    }
}
