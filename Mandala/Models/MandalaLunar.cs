using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mandala.Models
{
    public class MandalaLunar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int IdMandalaLunar { get; set; }

        public virtual ICollection<Parametro> Parametros { get; set; } 
    }
}