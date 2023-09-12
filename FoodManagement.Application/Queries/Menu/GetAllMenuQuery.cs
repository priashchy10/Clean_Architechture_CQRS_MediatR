using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagement.Application.Queries.Menu
{
    public class GetAllMenuQuery:IRequest<FoodManagement.Core.Entites.Menu>
    {
    }
}
