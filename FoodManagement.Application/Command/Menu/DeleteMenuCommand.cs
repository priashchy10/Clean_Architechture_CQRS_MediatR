using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagement.Application.Command.Menu
{
    public class DeleteMenuCommand:IRequest<FoodManagement.Core.Entites.Menu>
    {
        public int Id { get; set; }
        public DeleteMenuCommand(int id)
        {
            Id= id;
        }
    }
}
