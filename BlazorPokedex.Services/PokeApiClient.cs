using BlazorPokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Services
{
    public class PokeApiClient : IPokeApiClient
    {
        private readonly HttpClient _httpClient;

        public PokeApiClient(HttpClient httpClient)
        {
                _httpClient = httpClient;
        }


        public Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            throw new NotImplementedException();
        }

        public Task<Pokemon> GetPokemon(string name)
        {
            throw new NotImplementedException();
        }
    }
}
