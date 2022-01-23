using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Institution.Domain.Contract.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Type Of Key</typeparam>
    public interface IBaseKeyEntity<T>
    {
        public T Key { get; set; }
    }
}
