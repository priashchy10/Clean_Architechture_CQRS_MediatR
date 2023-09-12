using FoodManagement.Core.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagement.Application.Command.Menu
{
    public class CreateMenuCommand : IRequest<FoodManagement.Application.Response.AddMenu>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
