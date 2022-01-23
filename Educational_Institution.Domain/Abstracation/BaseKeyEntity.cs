using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Educational_Institution.Domain.Contract.Entities;

namespace Educational_Institution.Domain.Abstracation
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Type Of Key</typeparam>
    public abstract class BaseKeyEntity<T> : BaseEntity, IBaseKeyEntity<T>
    {
        public T Key { get ; set ; }
    }
}
