using AutoMapper;
using FoodManagement.Application.Command.Menu;
using FoodManagement.Application.Mapper;
using FoodManagement.Application.Response;
using FoodManagement.Core.Entites;
using FoodManagement.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagement.Application.Handler
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, AddMenu>
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IMapper _map;
        public CreateMenuCommandHandler(IMenuRepository menuRepository, IMapper map)
        {
            _menuRepository = menuRepository;
            _map = map;
        }

        public async Task<AddMenu> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            var mapData = _map.Map<Menu>(request);
            if(mapData is null)
            {
                throw new ApplicationException("map is not correct");
            }

            var menuObj = await _menuRepository.AddAsync(mapData);
            return _map.Map<AddMenu>(menuObj);
        }
    }
}
