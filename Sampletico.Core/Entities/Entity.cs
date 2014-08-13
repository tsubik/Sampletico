using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampletico.Core.Entities
{
    public class Entity
    {
        public T ToViewModel<T>()
        {
            return AutoMapper.Mapper.Map<T>(this);
        }
    }
}
