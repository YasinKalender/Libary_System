using Libary_System.Business.Abstract;
using Libary_System.Entities.ORM.Entities.Concrete;
using Libary_System.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Libary_System.Business.Concrete
{
    public class MessageManager : IMessageService
    {

        private MessageRepository messageRepository;

        public MessageManager()
        {
            messageRepository = new MessageRepository();
        }

        public void Add(Message entity)
        {
            messageRepository.Add(entity);
        }

        public void Delete(Message entity)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetAll(Expression<Func<Message, bool>> expression)
        {
            return messageRepository.GetAll(expression).ToList();
        }

        public Message GetByid(int id)
        {
            throw new NotImplementedException();
        }

        public Message GetOne(Expression<Func<Message, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
