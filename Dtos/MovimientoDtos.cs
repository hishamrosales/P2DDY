using System;
using System.Collections.Generic;
using System.Text;

namespace P2DDY.Dtos
{
    public class MovimientoDtos
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public int Poder { get; set; }
        public int Precision { get; set; }
        public int PokemonId { get; set; }
    }
}
