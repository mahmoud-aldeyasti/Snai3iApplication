using AutoMapper;
using Snai3i_BLL.DTO.AcountDto;
using Snai3i_BLL.DTO.ToolsDTO;
using Snai3i_DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snai3i_BLL.Automapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Tool, ReadToolDTO>()
            .ForMember(dest => dest.sizes, opt => opt.MapFrom(src => src.sizes));


           // CreateMap<Tool, ReadToolDTO>().ReverseMap();
            CreateMap<Tool, AddToolDTO>().ReverseMap();
            CreateMap<Tool, UpdateToolDTO>().ReverseMap();
            //CreateMap<Tool, DeleteToolDTO>().ReverseMap();

            CreateMap<Size, ReadSizeDTO>().ReverseMap();

            //CreateMap<Craft, CraftAddDTO>().ReverseMap();
            //CreateMap<Craft, CraftReadDTO>().ReverseMap();
            //CreateMap<Craft, CraftUdateDTO>().ReverseMap();

        }

    }
}
