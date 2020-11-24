using ATravelersGuideToSerdan.Models;
using ATravelersGuideToSerdan.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATravelersGuideToSerdan.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<CreatePlayer1ViewModel, PlayingCharacter>();
            CreateMap<PlayingCharacter, CreatePlayer1ViewModel>();
        }
    }
}
