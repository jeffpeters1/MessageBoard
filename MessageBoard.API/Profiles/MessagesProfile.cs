using AutoMapper;

namespace MessageBoard.API.Profiles
{
    public class MessagesProfile : Profile
    {
        public MessagesProfile()
        {
            CreateMap<Entities.Message, Models.MessageDto>();

            CreateMap<Models.MessageForCreationDto, Entities.Message>();
        }
    }
}
