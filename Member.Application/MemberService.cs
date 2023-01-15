using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application
{
    internal class MemberService : IMemberService
    {
        private readonly IMemberRepositry memberRepositry;
        public MemberService(IMemberRepositry memberRepositry)
        {
            this.memberRepositry = memberRepositry;
        }
        List<Domain.Member> IMemberService.GetAllMembers()
        {
            return this.memberRepositry.GetAllMembers();
        }
    }
}
