using AutoMapper;
using CodeBuildDeploy.Blogs.DA.Entities;

namespace CodeBuildDeploy.Blogs.BusinessLogic.Mapping
{
    internal sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, Contract.Dto.Category>();
            CreateMap<Tag, Contract.Dto.Tag>();
            CreateMap<Post, Contract.Dto.Post>();
        }
    }
}
