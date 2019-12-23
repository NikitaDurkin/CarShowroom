using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CarShowroom.Database;
using CarShowroom.Database.Models;
using CarShowroom.Domain.Interfaces;
using CarShowroom.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShowroom.Domain.Services
{
    /// <inheritdoc/>
    public class ClientService : IClientService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public ClientService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc/>
        public async Task<List<ClientModel>> GetAll()
        {
            var result = await _context.Clients.ToListAsync();
            return _mapper.Map<List<Client>, List<ClientModel>>(result);
        }
        
        /// <inheritdoc/>
        public async Task<ClientModel> GetClient(Guid guid)
        {
            var result = await _context.Clients.FindAsync(guid);
            return _mapper.Map<ClientModel>(result);
        }

        /// <inheritdoc/>
        public async Task<Guid> CreateClient(ClientModel clientModel)
        {
            var result = _mapper.Map<Client>(clientModel);
            _context.Clients.Add(result);
            await _context.SaveChangesAsync();
            return result.Guid;
        }

        /// <inheritdoc/>
        public async Task<Guid> UpdateClient(Guid guid, ClientModel clientModel)
        {
            Client client = _context.Clients.Find(guid);
            client.FullName = clientModel.FullName;
            client.Address = clientModel.Address;
            client.Phone = clientModel.Phone;
            client.Email = clientModel.Email;
            client.Orders = new List<Order>();
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
            return client.Guid;
        }

        /// <inheritdoc/>
        public async Task DeleteClient(Guid guid)
        {
            var result = await _context.Clients.FindAsync(guid);
            _context.Clients.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}