using CoreApi.Models;
using CoreApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class ClientController : ControllerBase
    {
        private readonly ClientService _clientService;

        public ClientController(ClientService clientService)
        {
            _clientService = clientService;
        }


        [HttpPost]
        public async Task<ClienteCreateResponse> Create(Cliente client)
        {
            return await _clientService.Create(client);
        }

        [HttpGet("{id}")]
        public async Task<Cliente> GetById(string id)
        {
            return await _clientService.GetById(id);
        }

        [HttpGet]
        public async Task<List<Cliente>> GetAll()
        {
            return await _clientService.GetAll();
        }


        [HttpPut]
        public async Task<string> Replace(Cliente client)
        {
            return await _clientService.Replace(client);
        }


        [HttpDelete("{id}")]
        public async Task<string> Delete(string id)
        {
            return await _clientService.Delete(id);
        }

    }
}
