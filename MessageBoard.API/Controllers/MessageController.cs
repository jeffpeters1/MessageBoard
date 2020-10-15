using AutoMapper;
using MessageBoard.API.Models;
using MessageBoard.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MessageBoard.API.Controllers
{
    [ApiController]
    [Route("api/messages")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageBoardRepository _messageBoardRepository;
        private readonly IMapper _mapper;

        public MessageController(IMessageBoardRepository messageBoardRepository, IMapper mapper)
        {
            _messageBoardRepository = messageBoardRepository
                ?? throw new ArgumentNullException(nameof(messageBoardRepository));
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper)); ;
        }

        [HttpGet()]
        public ActionResult<IEnumerable<MessageDto>> GetMessages()
        {
            var messages = _messageBoardRepository.GetAll();
            return Ok(_mapper.Map<IEnumerable<MessageDto>>(messages));
        }

        [HttpGet("{messageId}", Name="GetMessage")]
        public IActionResult GetMessage(Guid messageId)
        {
            var message = _messageBoardRepository.GetMessage(messageId);
            return Ok(_mapper.Map<MessageDto>(message));
        }

        [HttpPost]
        public ActionResult<MessageDto> CreateMessage(MessageForCreationDto message)
        {
            var messageEntity = _mapper.Map<Entities.Message>(message);

            _messageBoardRepository.AddMessage(messageEntity);
            _messageBoardRepository.Save();

            var messageToReturn = _mapper.Map<MessageDto>(messageEntity);

            return CreatedAtRoute("GetMessage", new { messageId = messageToReturn.Id}, messageToReturn);
        }
    }
}
