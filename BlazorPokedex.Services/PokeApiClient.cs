using BlazorPokedex.Models;
using BlazorPokedex.Models.Pagination;
using Newtonsoft.Json;
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


        public async Task<IEnumerable<Pokemon>> GetAllPokemons(PaginationParameters parameters)
        {
           var pokemonList = JsonConvert.DeserializeObject<ResultObject>(await _httpClient.GetStringAsync($"pokemon?limit={parameters.PageSize}&offset={parameters.offSet}"));

            var resultList = new List<Pokemon>();

            foreach (var pokemon in pokemonList.Pokemons) 
            {
                resultList.Add(await GetPokemon(pokemon.Name));
            }
            return resultList;
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
          return  JsonConvert.DeserializeObject<Pokemon>(await _httpClient.GetStringAsync($"pokemon/{name}"));

        

        }
    }
}
