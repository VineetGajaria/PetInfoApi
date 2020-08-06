namespace PetInfoApi.Manager
{
    public interface IPetInfoManager
    {
        int RegisterPetOwner(PetOwnerDomainModel petOwnerDomainModel);

        int AddPet(PetDomainModel petDomainModel);
    }
}