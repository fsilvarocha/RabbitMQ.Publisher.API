using Microsoft.AspNetCore.Mvc;
using Rabbit.Models.Entities;
using Rabbit.Services.Interface;

namespace RabbitMQ.Publisher.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitMensagensController : Controller
    {
        private readonly IRabbitMensagemService _service;

        public RabbitMensagensController(IRabbitMensagemService service)
        {
            _service = service;
        }

        [HttpPost]
        public void AddMensagem(RabbitMensagem mensagem) =>
            _service.SendMensagem(mensagem);
    }
}
