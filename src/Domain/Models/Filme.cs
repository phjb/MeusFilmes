using System.Collections.Generic;

namespace Domain.Models
{
   public class Filme : Entity
    {
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public int Ano { get; set; }
        public List<Genero> Generos { get; set; }
        public List<Midia> Midias { get; set; }
        public List<Pessoa> Pessoas { get; set; }
    }
}