using AutoMapper;
using FoodManagement.Application.Queries.Food;
using FoodManagement.Application.Response;
using FoodManagement.Core.Entites;
using FoodManagement.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagement.Application.Handler
{
    public class GetMenuQueryHandler : IRequestHandler<GetMenuQuery, Menu>
    {
        private readonly IMapper _mappers;
        private IMenuRepository _menuRepository;
        public GetMenuQueryHandler(IMenuRepository menuRepository, IMapper mappers)
        {
            _menuRepository = menuRepository;
            _mappers = mappers;
        }
        public Task<Menu> Handle(GetMenuQuery request, CancellationToken cancellationToken)
        {
            return _menuRepository.FindByIdAsync(request.Id);
        }
    }
}
