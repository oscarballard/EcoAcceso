using AutoMapper;
using EcoAcceso.Core.Application.Dtos.ProctectedArea;
using EcoAcceso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<ProtectedArea, CreateProtectedAreaDto>()
            .ReverseMap();
        }
    }
}
