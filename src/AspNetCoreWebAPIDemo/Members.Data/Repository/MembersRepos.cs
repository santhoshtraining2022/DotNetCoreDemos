using Members.Data.Interfaces;
using Members.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.Data.Repository
{
    public class MembersRepos : IMembersRepos
    {
        List<Member> members = new List<Member>()
        {
            new Member{ RegId=1001, Name = "Abinav", deptname="Quality"},
             new Member{ RegId=1002, Name = "Abhisek", deptname="Prod"},

              new Member{ RegId=1001, Name = "Sourabh", deptname="Quality"},

        };

        public List<Member> GetAllMembers()
        {
            return members;
        }

        public Member GetMember(int regId)
        {
            return members.FirstOrDefault(n=> n.RegId== regId);
        }
    }
}
