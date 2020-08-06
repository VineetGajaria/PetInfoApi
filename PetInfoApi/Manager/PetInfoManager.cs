using PetInfoApi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetInfoApi.Manager
{
    public class PetInfoManager : IPetInfoManager
    {

        private readonly IPetInfoRepository _petInfoRepository;

        public PetInfoManager(IPetInfoRepository petInfoRepository)
        {
            _petInfoRepository = petInfoRepository;
        }

        public int RegisterPetOwner(PetOwnerDomainModel petOwnerDomainModel)
        {
            PetOwner petOwnerEntity = new PetOwner()
            {
                FirstName = petOwnerDomainModel.FirstName,
                LastName = petOwnerDomainModel.LastName,
                Password = petOwnerDomainModel.Password,
                UserLogin = petOwnerDomainModel.UserLogin,
                AddressInfo = petOwnerDomainModel.AddressInfo,

            };

            _petInfoRepository.AddPetOwner(petOwnerEntity);

            return petOwnerEntity.PetOwnerId;
        }

        public int AddPet(PetDomainModel petDomainModel)
        {
            Pet pet = new Pet()
            {
                PetOwnerId = petDomainModel.PetOwnerId,
                Name = petDomainModel.Name,
                Type = petDomainModel.Type,
                CollarBarCode = petDomainModel.CollarBarCode
            };

            _petInfoRepository.AddPet(pet);

            return pet.PetId;
        }
    }
}
