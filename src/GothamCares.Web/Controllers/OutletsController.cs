using GothamCares.BusinessServices.Contracts;
using GothamCares.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GothamCares.DataServices.Context;
using GothamCares.BusinessServices.Dtos;

namespace GothamCares.Web.Controllers
{
    public class OutletsController : Controller
    {
        private readonly IOutletService outletService; //from business service 
        private readonly ILogger<OutletsController> logger;

        public OutletsController(IOutletService outletService, ILogger<OutletsController> logger)
        {
            this.outletService = outletService;
            this.logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var outletDtos = await outletService.GetAllOutlets();  //from business DTOS
            List<OutletVM> outletList = outletDtos
                .Select(o => new OutletVM() { Id = o.Id, Name = o.Name, StreetName=o.StreetName, Landmark=o.Landmark ,OpeningDate=o.OpeningDate})
                .ToList();

            return View(outletList);
        }
        [HttpGet]
        [Route("Outlets/add")]
        public   IActionResult AddOutlet()
        {
            return View();
        }

        [HttpPost]
        [Route("Outlets/add")]
         [ValidateAntiForgeryToken]
        public  async Task<IActionResult> AddOutlet([FromForm] OutletVM outletVM)
        {
            OutletDto outletDto= new OutletDto();
            outletDto.Id = outletVM.Id;
            outletDto.Name = outletVM.Name;
            outletDto.StreetName = outletVM.StreetName;
            outletDto.Landmark = outletVM.Landmark;
            outletDto.OpeningDate=outletVM.OpeningDate.Date.Date;
           // outletDto.ReqVounteers = outletVM.ReqVolunteers;

            bool isSucess = await outletService.CreateOutlet(outletDto);

           return RedirectToAction("Index");
        }
    }
}
