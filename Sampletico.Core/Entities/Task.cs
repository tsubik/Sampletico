using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampletico.Core.Entities
{
    public class Task : Entity
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public int Priority { get; set; }
        public User CreatedByUser { get; set; }
        public User AssignedToUser { get; set; }
    }
}
