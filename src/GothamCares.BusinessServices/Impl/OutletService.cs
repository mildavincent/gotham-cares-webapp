using GothamCares.BusinessServices.Contracts;
using GothamCares.BusinessServices.Dtos;
using GothamCares.Data;
using GothamCares.DataServices.Contracts;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace GothamCares.BusinessServices.Impl
{
    public class OutletService : IOutletService
    {
        private readonly IOutletDataService outletDataService;
        private readonly ILogger<OutletService> logger;

        public OutletService(IOutletDataService outletDataService, ILogger<OutletService> logger)
        {
            //keeps track of the works
            this.outletDataService = outletDataService;
            this.logger = logger;
        }

        public async Task<List<OutletDto>> GetAllOutlets()
        {
            List<Outlet> outlets = await outletDataService.GetAllOutlets();
            List<OutletDto> outletDtos = outlets.Select(o => new OutletDto() { 
              Id = o.Id,
              Name = o.Name,
              StreetName =o.StreetName, 
              Landmark= o.Landmark ,
              OpeningDate=o.OpeningDate})
             .ToList();            

            return outletDtos;
        }

        public async Task<List<OutletDto>> GetByDate(DateTime openingDate)
        {
            List<Outlet> outlets = await outletDataService.GetByDate(openingDate);
            List<OutletDto> outletDtos = outlets.Select(o => new OutletDto()
             {   
                 Name = o.Name

             }) .ToList();            

            return outletDtos;
        }
         public async Task<bool> CreateOutlet(OutletDto outletDto)
        {
           
            List<OutletDto> outletDtos = await GetByDate(outletDto.OpeningDate);
            bool has = outletDtos.Any(o=>o.Name.Contains(outletDto.Name));
            if(has)
            {
               
                Console.WriteLine("Outlet Name Already Exists");
                return has;
            }
            else if (outletDtos.Count>=10)
            {
                 Console.WriteLine("Outlets limit exeeded 10");
                return false;
            }
            else
            {
                Outlet outlets = new Outlet();
                outlets.Name = outletDto.Name;
                outlets.StreetName = outletDto.StreetName;
                outlets.Landmark = outletDto.Landmark;
                outlets.OpeningDate = outletDto.OpeningDate;
                //outlets.ReqVolunteers = outletDto.ReqVolunteers;

                bool IsSucess = await outletDataService.CreateOutlet(outlets);
                return IsSucess;
            } 
            
        }

    }
}
