using System;
using System.Collections.Generic;

namespace PetInfoApi.DAL
{
    public class Pet
    {
        public int PetId { get; set; }

        public int PetOwnerId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string CollarBarCode { get; set; }

    }
}
