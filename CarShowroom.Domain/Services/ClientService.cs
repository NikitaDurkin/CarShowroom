using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarShowroom.Domain.Interfaces;
using CarShowroom.Domain.Models;

namespace CarShowroom.Domain.Services
{
    /// <inheritdoc/>
    public class ClientService : IClientService
    {
        /// <inheritdoc/>
        public Task<List<ClientModel>> GetAll()
        {
            throw new NotImplementedException();
        }
        
        /// <inheritdoc/>
        public Task<ClientModel> GetClient(Guid guid)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Guid> CreateClient(ClientModel clientModel)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Guid> UpdateClient(Guid guid, ClientModel clientModel)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task DeleteClient(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}