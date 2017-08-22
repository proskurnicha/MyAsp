using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MyAsp.Dtos;
using MyAsp.Models;

namespace MyAsp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            //Dto to domain

            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.ID, opt => opt.Ignore());
            Mapper.CreateMap<Movie, MovieDto>().ForMember(c => c.Id, opt => opt.Ignore());
        }

    }
}