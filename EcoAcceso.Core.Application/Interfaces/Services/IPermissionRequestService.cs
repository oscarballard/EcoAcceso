using EcoAcceso.Core.Application.Dtos.PermissionRequest;
using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using EcoAccesso.Core.Application.Interfaces.Services;
using EcoAccesso.Core.Domain.Entities;

namespace EcoAcceso.Core.Application.Interfaces.Services
{
    public interface IPermissionRequestService : IGenericService<CreatePermissionRequestDto, GetPermissionRequestDto, PermissionRequest>
    {
    }
}
