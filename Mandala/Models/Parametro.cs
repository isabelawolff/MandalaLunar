using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mandala.Models
{
    public class Parametro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int IdParametro { get; set; }

        public string NomeParametro { get; set; }

        public CategoriaParametros Categoria { get; set; }
    }
}