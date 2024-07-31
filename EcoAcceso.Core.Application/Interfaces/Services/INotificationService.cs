using EcoAcceso.Core.Application.Dtos.Notifications;
using EcoAccesso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Domain.Entities;


namespace EcoAcceso.Core.Application.Interfaces.Services
{
    public interface INotificationService : IGenericService<CreateNotificationDto, GetNotificationDto, Notification>
    {
    }
}
