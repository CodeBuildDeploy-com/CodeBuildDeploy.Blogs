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
            CreateMap<Post, Contract.Dto.Post>()
                .ForMember(post => post.Tags, options => options.MapFrom(post => post.PostTags.Select(postTag => postTag.Tag)));
        }
    }
}
