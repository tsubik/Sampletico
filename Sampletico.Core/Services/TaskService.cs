using Sampletico.Core.Entities;
using Simple.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sampletico.Core.Services
{
    public class TaskService
    {
        public static User FindById(int id)
        {
            return Database.Open().Tasks.FindById(id);
        }

        public IEnumerable<Task> FindAllAssignedToUser(int userId)
        {
            return Database.Open().Tasks.FindAllByAssignedToUserId(userId).ToList<Task>();
        }
    }
}
