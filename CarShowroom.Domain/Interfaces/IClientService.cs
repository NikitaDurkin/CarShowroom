using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarShowroom.Domain.Models;

namespace CarShowroom.Domain.Interfaces
{
    /// <summary>
    /// Сервис по работе с клиентами
    /// </summary>
    public interface IClientService
    {
        /// <summary>
        /// Получение всех клиентов
        /// </summary>
        /// <returns></returns>
        Task<List<ClientModel>> GetAll();

        /// <summary>
        /// Получение информации о одном клиенте
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиента</param>
        /// <returns></returns>
        Task<ClientModel> GetClient(Guid guid);

        /// <summary>
        /// Добавление клиента
        /// </summary>
        /// <param name="clientModel">Модель клиента</param>
        /// <returns></returns>
        Task<Guid> CreateClient(ClientModel clientModel);

        /// <summary>
        /// Редакторование информации о клиенте
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиента</param>
        /// <param name="clientModel">Модель клиента</param>
        /// <returns></returns>
        Task<Guid> UpdateClient(Guid guid, ClientModel clientModel);

        /// <summary>
        /// Удаление клиента
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиента</param>
        /// <returns></returns>
        Task DeleteClient(Guid guid);
    }
}