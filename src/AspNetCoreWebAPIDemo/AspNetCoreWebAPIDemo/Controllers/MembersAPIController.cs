using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Members.Data.Interfaces;
using Members.Data.Repository;
using Members.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreWebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersAPIController : ControllerBase
    {
        IMembersRepos members = new MembersRepos();


        // GET: api/<MembersAPIController>
        [HttpGet]
        public List<Member> Get()
        {
            return members.GetAllMembers();
        }

        // GET api/<MembersAPIController>/5
        [HttpGet("{id}")]
        public Member Get(int id)
        {
            return members.GetMember(id);
        }

        // POST api/<MembersAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MembersAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MembersAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
