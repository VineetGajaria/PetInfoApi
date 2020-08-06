using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetInfoApi.Manager;

namespace PetInfoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetInfoController : ControllerBase
    {

        private readonly ILogger<PetInfoController> _logger;
        private IPetInfoManager _petInfoManager;

        public PetInfoController(ILogger<PetInfoController> logger, IPetInfoManager petInfoManager)
        {
            _logger = logger;
            _petInfoManager = petInfoManager;
        }

        [HttpPost]
        [Route("RegisterPetOwner")]
        public int RegisterPetOwner(PetOwnerDomainModel petOwner)
        {
            return _petInfoManager.RegisterPetOwner(petOwner);
        }

        [HttpPost]
        [Route("AddPet")]
        public int AddPet(PetDomainModel petOwner)
        {
            return _petInfoManager.AddPet(petOwner);
        }
    }
}
