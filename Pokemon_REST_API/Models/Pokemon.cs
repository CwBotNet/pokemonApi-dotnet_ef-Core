namespace Pokemon_REST_API.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string? PokemonName{ get; set;}
        public string? PokemonType { get; set;}
        public int? HealthPoint { get; set; }
        public int? Attack { get; set; }
        public int? Defance { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefance { get; set;}
        public int Speed {get; set;}
    }
}
