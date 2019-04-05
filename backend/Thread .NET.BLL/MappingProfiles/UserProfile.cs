﻿using AutoMapper;
using Thread_.NET.Common.DTOs;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.MappingProfiles
{
    public sealed class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
               .ForMember(dest => dest.Avatar, src => src.MapFrom(s => s.Avatar != null ? s.Avatar.URL : string.Empty));

            CreateMap<UserDTO, User>()
                .ForMember(u => u.Avatar, dto => dto.MapFrom(s => string.IsNullOrEmpty(s.Avatar) ? null : new Image { URL = s.Avatar }));
        }
    }
}
