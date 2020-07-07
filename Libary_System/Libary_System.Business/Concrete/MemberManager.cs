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
    public class MemberManager : IMemberService
    {
        MemberRepository memberRepository;

        public MemberManager()
        {
            memberRepository = new MemberRepository();
        }

        public void Add(Member entity)
        {
            memberRepository.Add(entity);
        }

        public void Delete(Member entity)
        {
            memberRepository.Delete(entity);
        }

        public List<Member> GetAll(Expression<Func<Member, bool>> expression)
        {
            return memberRepository.GetAll(expression);
        }

        public Member GetByid(int id)
        {
            return memberRepository.GetByid(id);
        }

        public Member GetOne(Expression<Func<Member, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Member Info(string mail, string pass)
        {
            return memberRepository.Info(mail, pass);
        }

        public Member PassBook(Expression<Func<Member, bool>> expression)
        {
            return memberRepository.PassBook(expression);
        }

        public void Update(Member entity)
        {
            memberRepository.Update(entity);
        }
    }
}
