using System;
using System.Collections.Generic;

namespace PetInfoApi
{
    public class PetOwnerDomainModel
    {
        public string UserLogin { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsPremiumUser { get; set; }

        public Address AddressInfo { get; set; }

    }
}
