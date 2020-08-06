using System;
using System.Collections.Generic;

namespace PetInfoApi.DAL
{
    public class PetOwner
    {

        public int PetOwnerId { get; set; }

        public string UserLogin { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address AddressInfo { get; set; }

    }
}
