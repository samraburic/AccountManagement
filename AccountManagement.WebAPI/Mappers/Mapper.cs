using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Model.Requests;
using AccountManagement.Model;


namespace AccountManagement.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Client, Client>();
            CreateMap<ClientUpsertRequest, Database.Client>();

            CreateMap<Database.User, User>();
            CreateMap<UserUpsertRequerst, Database.User>();

            CreateMap<Database.Meeting, Meeting>();
            CreateMap<MeetingUpsertRequest, Database.Meeting>();
        }
    }

}
