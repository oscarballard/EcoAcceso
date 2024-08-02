using EcoAcceso.Core.Application.Dtos.Notifications;
using EcoAcceso.Core.Application.Interfaces.Services;
using EcoAcceso.WebApi.Controllers;
using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using EcoAccesso.Core.Application.Interfaces.Repositories;
using EcoAccesso.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcoAccesso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : BaseController<CreateNotificationDto, GetNotificationDto, Notification, INotificationService>
    {
        public NotificationController(INotificationService notificationService, ILogger<NotificationController> logger)
       : base(notificationService, logger)
        {
        }
    }
}
