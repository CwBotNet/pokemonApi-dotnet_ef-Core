using Microsoft.EntityFrameworkCore;
using Pokemon_REST_API.Models;

namespace Pokemon_REST_API.Data
{
    public class PokemonDbContext: DbContext
    {
        public PokemonDbContext(DbContextOptions<PokemonDbContext> options) : base(options)
        { 
        
        }

        public DbSet<Pokemon> Pokemons { get; set; }
    }
}
