using FoodManagement.Core.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagement.Core.Entites
{
    public class Menu: EntityBase<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
