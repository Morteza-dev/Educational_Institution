using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Educational_Institution.Domain.Abstracation;

namespace Educational_Institution.Domain.Models.Entities
{
    public class AttrValue:BaseKeyValueEntity<int, string>
    {
        public int AttrKey { get; set; }
        public int ProductKey { get; set; }
    }
}
