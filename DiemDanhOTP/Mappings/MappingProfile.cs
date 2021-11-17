using AutoMapper;
using DiemDanhOTP.Core.Domain;
using DiemDanhOTP.Resource;
using Upico.Core.ServiceResources;

namespace DiemDanhOTP.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserResource>();
          
        }
    }
}
