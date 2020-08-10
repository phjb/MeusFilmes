using System.Collections.Generic;

namespace Domain.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Funcao> Funcoes { get; set; }
    }
}