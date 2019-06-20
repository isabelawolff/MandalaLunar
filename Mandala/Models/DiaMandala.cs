using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mandala.Models
{
    public class DiaMandala
    {
        public string Id { get; set; }

        private DateTime data;

        public DateTime Data { get { return data; } set { data = value; Mes = value.ToString("MMyyyy"); } }

        public string Mes { get; set; }

        public int Extroversao { get; set; }
        public int Foco { get; set; }
        public int EnergiaSexual { get; set; }
        public int Vitalidade { get; set; }
        public int ForcaDeAcao { get; set; }
        public int AutoconfiancaProfissional { get; set; }
        public int AutoconfiancaPessoal { get; set; }
        public int Amorosidade { get; set; }

        public void GerarId()
        {
            Id = Guid.NewGuid().ToString();
        }

        public bool Validar(out List<string> validacoes)
        {
            validacoes = new List<string>();

            if (Data == DateTime.MinValue)
                validacoes.Add("A data deve ser preenchida.");
            if (Extroversao < 0 || Extroversao > 10)
                validacoes.Add("O nível de extroversão deve estar entre 0 e 10.");
            if (Foco < 0 || Foco > 10)
                validacoes.Add("O nível de Foco deve estar entre 0 e 10.");
            if (EnergiaSexual < 0 || EnergiaSexual > 10)
                validacoes.Add("O nível de energia sexual deve estar entre 0 e 10.");
            if (Vitalidade < 0 || Vitalidade > 10)
                validacoes.Add("O nível de vitalidade deve estar entre 0 e 10.");
            if (ForcaDeAcao < 0 || ForcaDeAcao > 10)
                validacoes.Add("O nível de força de ação deve estar entre 0 e 10.");
            if (AutoconfiancaPessoal < 0 || AutoconfiancaPessoal > 10)
                validacoes.Add("O nível de autoconfiança pessoal deve estar entre 0 e 10.");
            if (AutoconfiancaProfissional < 0 || AutoconfiancaProfissional > 10)
                validacoes.Add("O nível de autoconfiança profissional deve estar entre 0 e 10.");
            if (Amorosidade < 0 || Amorosidade > 10)
                validacoes.Add("O nível de amorosidade deve estar entre 0 e 10.");
            
            return validacoes.Count == 0;
        }

    }
}