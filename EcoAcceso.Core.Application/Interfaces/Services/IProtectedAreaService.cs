using EcoAccesso.Core.Application.Dtos.ProctectedArea;
using EcoAccesso.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Application.Interfaces.Services
{
    public interface IProtectedAreaService : IGenericService<CreateProtectedAreaDto, GetProtectedAreaDto, ProtectedArea>
    {
    }
}
