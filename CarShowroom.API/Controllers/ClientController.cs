using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarShowroom.Domain.Interfaces;
using CarShowroom.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarShowroom.API.Controllers
{
    /// <summary>
    /// Контроллер для работы с клиентами
    /// </summary>
    [Route("CarShowroom/Client")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        /// <summary>
        /// Получение всех клиентов
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public async Task<IEnumerable<ClientModel>> GetAll()
        {
            return await _clientService.GetAll();
        }

        /// <summary>
        /// Получение одного клиента
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиента</param>
        /// <returns></returns>
        [HttpGet("GetClient")]
        public async Task<ClientModel> GetClient(Guid guid)
        {
            return await _clientService.GetClient(guid);
        }

        /// <summary>
        /// Создание клиента
        /// </summary>
        /// <param name="clientModel">Модель клиента</param>
        /// <returns></returns>
        [HttpPost("CreateClient")]
        public async Task<Guid> CreateClient(ClientModel clientModel)
        {
            return await _clientService.CreateClient(clientModel);
        }

        /// <summary>
        /// Редактирование информации о клиенте
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиента</param>
        /// <param name="clientModel">Модель клиента</param>
        /// <returns></returns>
        [HttpPut("UpdateClient")]
        public async Task<Guid> UpdateClient(Guid guid, ClientModel clientModel)
        {
            return await _clientService.UpdateClient(guid, clientModel);
        }

        /// <summary>
        /// Удаление клиента
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиента</param>
        /// <returns></returns>
        [HttpDelete("DeleteClient")]
        public async Task DeleteClient(Guid guid)
        {
            await _clientService.DeleteClient(guid);
        }
    }
}