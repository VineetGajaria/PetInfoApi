using System;

namespace PetInfoApi
{
    public class PetDomainModel
    {

        public int PetOwnerId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string CollarBarCode { get; set; }

    }
}
