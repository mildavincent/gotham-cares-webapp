using GothamCares.BusinessServices.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace GothamCares.BusinessServices.Contracts
{
    public interface IOutletService
    {
       Task<List<OutletDto>> GetAllOutlets();
        Task<List<OutletDto>> GetByDate(DateTime openingDate);
         Task<bool> CreateOutlet(OutletDto outlet);
      


    }
}
