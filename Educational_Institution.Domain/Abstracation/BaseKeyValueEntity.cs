using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Institution.Domain.Abstracation
{
  /// <summary>
  /// 
  /// </summary>
  /// <typeparam name="T">Type Of Key</typeparam>
  /// <typeparam name="TValue">Type Of Value</typeparam>
    public abstract class BaseKeyValueEntity<T,TValue>:BaseKeyEntity<T>
    {
        public TValue Value { get; set; }
    }
}
