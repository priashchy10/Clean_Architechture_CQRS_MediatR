using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagement.Core.Entites.Base
{
    public abstract class EntityBase<TId>: IEntityBase<TId>
    {
        public virtual TId Id { get; set; }
    }
}
