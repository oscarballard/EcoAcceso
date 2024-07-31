using AutoMapper;
using EcoAcceso.Core.Application.Dtos.MaintenanceEvent;
using EcoAcceso.Core.Application.Dtos.Notifications;
using EcoAcceso.Core.Application.Dtos.PermissionRequest;
using EcoAcceso.Core.Application.Dtos.Reservation;
using EcoAcceso.Core.Application.Dtos.VisitHistory;
using EcoAccesso.Core.Application.Dtos.IncidentReport;
using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using EcoAccesso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {

            CreateMap<PermissionRequest, CreatePermissionRequestDto>()
                .ReverseMap();

            CreateMap<GetPermissionRequestDto, PermissionRequest>()
                .ReverseMap();

            CreateMap<ProtectedArea, CreateProtectedAreaDto>()
                .ReverseMap();

            CreateMap<GetProtectedAreaDto, ProtectedArea>()
                .ReverseMap();

            CreateMap<Reservation, CreateReservationDto>()
                .ReverseMap();

            CreateMap<GetReservationDto, Reservation>()
                .ReverseMap();

            CreateMap<Notification, CreateNotificationDto>()
                .ReverseMap();

            CreateMap<GetNotificationDto, Notification>()
                .ReverseMap();


            CreateMap<VisitHistory, CreateVisitHistoryDto>()
                .ReverseMap();

            CreateMap<GetVisitHistoryDto, VisitHistory>()
                .ReverseMap();

            CreateMap<MaintenanceEvent, CreateMaintenanceEventDto>()
                .ReverseMap();

            CreateMap<GetMaintenanceEventDto, MaintenanceEvent>()
                .ReverseMap();

            CreateMap<IncidentReport, CreateIncidentReportDto>()
                .ReverseMap();

            CreateMap<GetIncidentReportDto, IncidentReport>()
                .ReverseMap();
        }
    }
}
