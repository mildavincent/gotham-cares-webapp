using GothamCares.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace GothamCares.DataServices.Contracts
{
    //services from Outlet 
    public interface IOutletDataService
    {
        Task<List<Outlet>> GetAllOutlets();

        Task<Outlet> GetById(int outletId);

        Task<bool> CreateOutlet(Outlet outlet);

        Task<bool> UpdateOutlet(Outlet outlet);

        Task<bool> DeleteOutlet(int outletId);
        Task<List<Outlet>> GetByDate(DateTime openingDate);
    }
}
