using AutoMapper;
using EcoAcceso.Core.Application.Dtos.Notifications;
using EcoAcceso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using EcoAccesso.Core.Application.Interfaces.Repositories;
using EcoAccesso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Application.Services;
using EcoAccesso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Services
{
    public class NotificationServices : GenericService<CreateNotificationDto, GetNotificationDto, Notification>, INotificationService
    {
        private readonly INotificationRepository _NotificationRepository;
        private readonly IMapper _mapper;
        public NotificationServices(INotificationRepository NotificationRepository, IMapper mapper) : base(NotificationRepository, mapper)
        {
            _NotificationRepository = NotificationRepository;
            _mapper = mapper;
        }
    }
}
