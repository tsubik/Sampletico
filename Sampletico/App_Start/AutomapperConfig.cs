using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Sampletico.Core.Entities;
using Sampletico.ViewModels;

namespace Sampletico
{
    public class AutomapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<User, UserListItemViewModel>();
            Mapper.CreateMap<User, UserEditViewModel>();
        }
    }
}