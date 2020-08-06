using System;
using System.Collections.Generic;

namespace PetInfoApi
{
    public class AddPetRequestDomainModel
    {
        public int PetOwnerId { get; set; }

        public List<PetDomainModel> Pets { get; set; }

    }
}
