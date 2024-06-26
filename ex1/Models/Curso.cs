using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ex1.Models
{
    public class Curso
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        //indicate the studants IDs
        public List <int> AlunosInscrito  { get; set; }
    
    }
}