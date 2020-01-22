using AutoMapper;

namespace SampleArch.Infrastructure
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Model.Country, Models.Country>();
                cfg.CreateMap<Model.Person, Models.Person>();
            });
        }
    }
}