using Members.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.Data.Interfaces
{
   public interface IMembersRepos
    {
      List<Member>  GetAllMembers();
        Member GetMember(int regId);
    }
}
