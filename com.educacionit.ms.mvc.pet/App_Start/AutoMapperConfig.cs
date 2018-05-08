using AutoMapper;
using com.educacionit.ms.pet.domain.model;
using COM.Educacionit.MS.MVC.Pet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.educacionit.ms.mvc.pet.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMappers()
        {
            Mapper.Initialize(mapper =>
            {
                mapper.CreateMap<AddressModel, Address>();
                mapper.CreateMap<Address, AddressModel>();

                mapper.CreateMap<AdopterModel, Adopter>();
                mapper.CreateMap <Adopter, AdopterModel > ();

                mapper.CreateMap<AdoptionModel, Adoption>();
                mapper.CreateMap <Adoption, AdoptionModel> ();

                mapper.CreateMap<CityModel, City>();
                mapper.CreateMap <City, CityModel> ();

                mapper.CreateMap<CountryModel, Country>();
                mapper.CreateMap <Country, CountryModel> ();

                mapper.CreateMap<OwnerModel, Owner>();
                mapper.CreateMap <Owner, OwnerModel > ();

                mapper.CreateMap<PetModel, Pet>();
                mapper.CreateMap <Pet, PetModel > ();

                mapper.CreateMap<PetTypeModel, PetType >();
                mapper.CreateMap <Pet, PetTypeModel > ();
                
            });
        }
    }
}