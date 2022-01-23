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
    public class Invoice:BaseKeyEntity<int>
    {
        public int UserID { get; set; }
        public int Price { get; set; }
        public DateTime DateTimeOfInvoice { get; set; }
        public int FinalPrice { get; set; }
    }
}
