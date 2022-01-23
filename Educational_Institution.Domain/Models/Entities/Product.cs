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
    public class Product:BaseKeyEntity<int>
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int MyProperty { get; set; }
        public int Inventory { get; set; }
        public string Note { get; set; }
        public int CategoryID { get; set; }
        public int FinalPrice { get; set; }

    }
}
