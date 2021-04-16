using CoreApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreApi.Services.Interface
{
    public interface IClientService
    {
        Task<ClienteCreateResponse> Create(Cliente client);
        Task<Cliente> GetById(string id);
        Task<List<Cliente>> GetAll();
        Task<string> Replace(Cliente client);
        Task<string> Delete(string id);
    }
}
