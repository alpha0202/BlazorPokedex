using BlazorPokedex.Models;
using BlazorPokedex.Models.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Services
{
    public interface IPokeApiClient
    {
        Task<IEnumerable<Pokemon>> GetAllPokemons(PaginationParameters parameters);
        Task<Pokemon> GetPokemon(string name);
    }
}
