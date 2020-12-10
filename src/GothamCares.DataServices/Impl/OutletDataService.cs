using GothamCares.Data;
using GothamCares.DataServices.Context;
using GothamCares.DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothamCares.DataServices.Impl
{
    public class OutletDataService : IOutletDataService
    {
        private readonly AppDbContext appDbContext;
        public OutletDataService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<bool> CreateOutlet(Outlet outlet)
        {
            await appDbContext.Outlets.AddAsync(outlet);
            await appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteOutlet(int outletId)
        {
            throw new NotImplementedException();
        }

        //using ef to get data from db
        public Task<List<Outlet>> GetAllOutlets()
        {
              List<Outlet> outlets = appDbContext.Outlets.Select(o => o).ToList();
            return Task.FromResult(outlets);

        }  /* public async Task<List<Outlet>> GetAllOutlets()
             {
                 // Todo: Use EF and get from DB

                 List<Outlet> outlets = new List<Outlet>()
                 {
                     new Outlet{Id=1, Name="Subway"},
                     new Outlet{Id=2, Name="Paradise"},
                     new Outlet{Id=3, Name="Pizza Hut"},
                     new Outlet{Id=3, Name="McDonalds"},
                     new Outlet{Id=4, Name="Burger King"},
                     new Outlet{Id=5, Name="KFC"},
                     new Outlet{Id=6, Name="Chai house"},
                     new Outlet{Id=7, Name="Cream Stone"}
                 };

                 return await Task.FromResult(outlets);

             }
            */

        public async Task<Outlet> GetById(int outletId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateOutlet(Outlet outlet)
        {
            throw new NotImplementedException();
        }
         public Task<List<Outlet>> GetByDate(DateTime openingDate)
        {
              List<Outlet> outlets = appDbContext.Outlets.Where(o=>o.OpeningDate==openingDate).Select(o => o).ToList();
            return Task.FromResult(outlets);

        } 

    }
}
