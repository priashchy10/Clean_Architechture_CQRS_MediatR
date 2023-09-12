using FoodManagement.Core.Entites;
using FoodManagement.Core.Repository;
using FoodManagement.Infrastracture.Data;
using FoodManagement.Infrastracture.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagement.Infrastracture.Repository
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(FoodContext foodContext) : base(foodContext)
        {
        }
    }
}
