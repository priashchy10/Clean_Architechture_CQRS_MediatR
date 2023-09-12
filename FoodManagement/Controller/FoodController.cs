using FoodManagement.Application.Command.Menu;
using FoodManagement.Application.Queries.Food;
using FoodManagement.Application.Queries.Menu;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FoodManagement.Controller
{
    public class FoodController : ApiController
    {
        private readonly IMediator _mediator;
        public FoodController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        [HttpGet]
        public async Task<ActionResult> GetMenuById(int id)
        {
            var query = new GetMenuQuery(id);
            return Ok(await _mediator.Send(query));
        }

        //[HttpGet]
        //public async Task<ActionResult> GetAllMenu()
        //{
        //    return Ok(await _mediator.Send(new GetAllMenuQuery()));
        //}

        [HttpPost]
        public async Task<ActionResult> SaveMenu(CreateMenuCommand createMenuCommand)
        {
            return Ok(await _mediator.Send(createMenuCommand));
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteMenu(int id)
        {
            return Ok(await _mediator.Send(new DeleteMenuCommand(id)));
        }


    }
}
