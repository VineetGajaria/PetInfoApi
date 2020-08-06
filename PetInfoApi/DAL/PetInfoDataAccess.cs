using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PetInfoApi.DAL
{
    public class PetInfoDataAccess : IPetInfoRepository
    {

        public IConfiguration Configuration { get; }

        private readonly IWebHostEnvironment environment;

        private string jsonPetOwnerFilePath;
        private string jsonPetFilePath;

        public PetInfoDataAccess(IConfiguration config, IWebHostEnvironment env)
        {
            Configuration = config;
            environment = env;

            jsonPetOwnerFilePath = Configuration["Paths:jsonPetOwnerFilePath"];
            jsonPetOwnerFilePath = environment.WebRootPath + jsonPetOwnerFilePath;

            jsonPetFilePath = Configuration["Paths:jsonPetFilePath"];
            jsonPetFilePath = environment.WebRootPath + jsonPetFilePath;
        }

        public void AddPetOwner(PetOwner petOwner)
        {
            List<PetOwner> petOwnerList = GetPetOwnerListJson();

            if (petOwnerList.Count == 0)
                petOwner.PetOwnerId = 1;
            else
                petOwner.PetOwnerId = petOwnerList.Last().PetOwnerId + 1;

            petOwnerList.Add(petOwner);
            var jsonPetOwner = JsonConvert.SerializeObject(petOwnerList);
            File.WriteAllText(jsonPetOwnerFilePath, jsonPetOwner);
        }

        private List<PetOwner> GetPetOwnerListJson()
        {
            string buffer = File.ReadAllText(jsonPetOwnerFilePath);
            List<PetOwner> petOwnerList = JsonConvert.DeserializeObject<List<PetOwner>>(buffer);
            return petOwnerList;
        }

        public void AddPet(Pet pet)
        {
            List<Pet> petList = GetPetListJson();

            if (petList.Count == 0)
                pet.PetId = 1;
            else
                pet.PetId = petList.Last().PetId + 1;

            petList.Add(pet);
            var jsonPet = JsonConvert.SerializeObject(petList);
            File.WriteAllText(jsonPetFilePath, jsonPet);
        }

        private List<Pet> GetPetListJson()
        {
            string buffer = File.ReadAllText(jsonPetFilePath);
            List<Pet> petList = JsonConvert.DeserializeObject<List<Pet>>(buffer);
            return petList;
        }
    }
}
