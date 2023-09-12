using FoodManagement.Core.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagement.Application.Queries.Food
{
    public class GetMenuQuery : IRequest<FoodManagement.Core.Entites.Menu>
    {
        public int Id { get; set; }
        public GetMenuQuery(int id)
        {
            Id = id;
        }
    }
}
