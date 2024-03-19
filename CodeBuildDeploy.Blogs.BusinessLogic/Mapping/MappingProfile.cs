using AutoMapper;

namespace CodeBuildDeploy.Blogs.BusinessLogic.Mapping
{
    internal sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Data.Category, Contract.Dto.Category>();
            CreateMap<Data.Tag, Contract.Dto.Tag>();
            CreateMap<Data.Post, Contract.Dto.Post>();
        }
    }
}
