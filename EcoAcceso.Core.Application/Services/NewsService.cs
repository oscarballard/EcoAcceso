using AutoMapper;
using EcoAcceso.Core.Application.Dtos.News;
using EcoAcceso.Core.Application.Dtos.ProctectedArea;
using EcoAcceso.Core.Application.Interfaces.Repositories;
using EcoAcceso.Core.Application.Interfaces.Services;
using EcoAcceso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Services
{
    public class NewsService : GenericService<CreateNewsDto, GetNewsDto, News>, INewsService
    {
        private readonly INewsRepository _newsRepository;
        private readonly IMapper _mapper;
        public NewsService(INewsRepository newsRepository, IMapper mapper) : base(newsRepository, mapper)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;
        }
    }
}
