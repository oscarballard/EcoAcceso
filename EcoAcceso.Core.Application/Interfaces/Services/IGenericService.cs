using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAcceso.Core.Application.Interfaces.Services
{
    public interface IGenericService<SaveViewModel, ViewModel, Model>
        where SaveViewModel : class
        where ViewModel : class
        where Model : class
    {
        public Task Update(SaveViewModel vm, int id);

        public Task<SaveViewModel> Add(SaveViewModel vm);

        public Task Delete(int id);

        public Task<SaveViewModel> GetByIdSaveViewModel(int id);

        public Task<List<ViewModel>> GetAllViewModel();
    }
}
