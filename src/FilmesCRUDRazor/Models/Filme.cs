using System;

namespace FilmesCRUDRazor.Models
{
    public class Filme
    {
        public int FilmeID { get; set; }

        public string Titulo { get; set; }

        public DateTime DataLancamento { get; set; }

        public string Genero { get; set; }

        public decimal Preco { get; set; }


    }
}