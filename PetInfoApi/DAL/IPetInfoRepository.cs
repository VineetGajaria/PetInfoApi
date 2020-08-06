using Microsoft.Extensions.Configuration;

namespace PetInfoApi.DAL
{
    public interface IPetInfoRepository
    {
        IConfiguration Configuration { get; }

        void AddPetOwner(PetOwner petOwner);

        void AddPet(Pet pet);
    }
}