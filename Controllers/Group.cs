using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Controllers
{
    [ApiController]
    [Route("/Group")]
    public class GroupController : ControllerBase
    {
        [HttpPost]
        public Group Create(Group group)
        {
            Storage.GroupStorage.Create(group)
            return group;
        }

        [HttpGet]
        public Group Read(int groupId)
        {
            return Storage.GroupStorage.Read(groupId);
        }

        [HttpPut]
        public Group Update(int groupId, Group newGroup)
        {
            return Storage.GroupStorage.Update(groupId, newGroup);
        }

        [HttpDelete]
        public bool Delete(int groupId)
        {
            return Storage.GroupStorage.Delete(groupId);
        }
    }
}