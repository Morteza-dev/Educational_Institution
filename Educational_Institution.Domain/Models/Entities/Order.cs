using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Educational_Institution.Domain.Abstracation;


namespace Educational_Institution.Domain.Models.Entities
{
    /// <summary>
    /// Type Of Key Is Int ( ID )
    /// </summary>
    public class Order:BaseKeyEntity<int>
    {
        public int ProductKey { get; set; }
        public bool IsReceived { get; set; }
        public int InvoiceKey { get; set; }
    }

}
