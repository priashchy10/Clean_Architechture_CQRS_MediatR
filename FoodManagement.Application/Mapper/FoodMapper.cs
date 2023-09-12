using AutoMapper;
using FoodManagement.Application.Command.Menu;
using FoodManagement.Application.Response;
using FoodManagement.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagement.Application.Mapper
{
    public class FoodMapper : Profile
    {
        public FoodMapper()
        {
            CreateMap<AddMenu, Menu>();
            CreateMap<Menu, AddMenu>();
            CreateMap<Menu, CreateMenuCommand>();
            CreateMap<CreateMenuCommand, Menu>();

        }
    }
}
