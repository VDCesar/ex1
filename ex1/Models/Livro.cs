using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ex1.Models
{
    public class Livro
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public int Ano { get; set; }

        public DateTime DataAqisicao { get; set; } = DateTime.Now;
    }
}