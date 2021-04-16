using CoreApi.Data.Interface;
using CoreApi.Models;
using CoreApi.Services.Interface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace CoreApi.Services
{
    public class ClientService : IClientService
    {
        private readonly IMongoCollection<Cliente> _clients;

        public ClientService(IDatabaseSettings settings)
        {
            var connection = new MongoClient(settings.ConnectionString);
            var database = connection.GetDatabase(settings.DataBaseName);

            _clients = database.GetCollection<Cliente>(settings.CollectionName);
        }


        public async Task<ClienteCreateResponse> Create(Cliente client)
        {
            if (client == null)
                throw new Exception(nameof(client));

            if (string.IsNullOrEmpty(client.Name))
                throw new Exception(nameof(client.Name));

            if (string.IsNullOrEmpty(client.Cpf))
                throw new Exception(nameof(client.Cpf));


            await _clients.InsertOneAsync(client);

            var clienteResponse = new ClienteCreateResponse()
            {
                Id = client.Id
             };
         
            return clienteResponse;
        }

        public async Task<Cliente> GetById(string id)
        {
            var result = _clients.Find<Cliente>(x => x.Id == id).FirstOrDefault();

            if (result == null)
                throw new Exception(nameof(result));

            return result;
        }

        public async Task<List<Cliente>> GetAll()
        {
            var result = await _clients.Find<Cliente>(client => true).ToListAsync();

            return result;
        }

        public async Task<string> Replace(Cliente client)
        {
            var checkId = GetById(client.Id);

            if (checkId == null)
                throw new Exception(nameof(checkId));

            if (client == null)
                throw new Exception(nameof(client));

            if (string.IsNullOrEmpty(client.Name))
                throw new Exception(nameof(client.Name));

            if (string.IsNullOrEmpty(client.Cpf))
                throw new Exception(nameof(client.Cpf));

            var result = await _clients.FindOneAndReplaceAsync<Cliente>(x => x.Cpf == client.Cpf, client);

            if (result == null)
                throw new Exception(nameof(result));

            return result.Id;
        }

        public async Task<string> Delete(string id)
        {
            if (string.IsNullOrEmpty(id) == null)
                throw new Exception(nameof(id));

            var result = await _clients.FindOneAndDeleteAsync(x => x.Id == id);

            return id;
        }
    }
}
