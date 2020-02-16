using AutoMapper;
using SimpleOnlineStoreRepositoryCore.Data.Entities;
using SimpleOnlineStoreRepositoryCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOnlineStoreRepositoryCore.Data.Profiles
{
    public class RegisterProfile : Profile
    {
        public RegisterProfile()
        {
            CreateMap<RegisterModel, AppUser>();
        }
    }
}
