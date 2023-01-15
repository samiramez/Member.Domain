using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application
{
    internal interface IMemberService
    {
        List<Domain.Member> GetAllMembers();
    }
}
