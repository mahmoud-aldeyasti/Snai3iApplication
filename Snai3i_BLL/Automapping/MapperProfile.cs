using AutoMapper;
using Snai3i_BLL.DTO.AcountDto;
using Snai3i_BLL.DTO.ReviewDto;
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
            CreateMap<ReviewAddDTO, Review>()
                .ForMember( dest => dest.Rate , act => act.MapFrom( src => src.Rating ) ).
                ReverseMap();
            CreateMap<Review, ReviewUpdateDTO>().ReverseMap(); 

            CreateMap<Review, ReviewReadDTO>().
                ForMember( dest => dest.UserName , act => act.MapFrom( src => src.user.UserName ) ).
                ForMember( dest => dest.workername , act => act.MapFrom( src => src.worker.UserName) ).
                ReverseMap() ;   
        }

    }
}
