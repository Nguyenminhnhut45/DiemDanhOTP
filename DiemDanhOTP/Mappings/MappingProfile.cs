using AutoMapper;
using DiemDanhOTP.Core.Domain;
using DiemDanhOTP.Resource;

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
