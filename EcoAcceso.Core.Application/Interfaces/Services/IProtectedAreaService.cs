using EcoAcceso.Core.Application.Dtos.ProctectedArea;
using EcoAcceso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Interfaces.Services
{
    public interface IProtectedAreaService : IGenericService<CreateProtectedAreaDto, GetProtectedAreaDto, ProtectedArea>
    {
    }
}
