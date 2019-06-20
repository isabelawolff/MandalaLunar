using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mandala.Models
{
    public class MandalaLunar
    {
        private string mes;

        public MandalaLunar(string mes, List<DiaMandala> dias)
        {
            this.mes = mes;
            Dias = dias;
        }

        public List<DiaMandala> Dias { get; set; }

        public bool MandalaPreenchida { get { return Dias.Count > 0; } }
        public string Mes { get { return mes; } }

        public int QuantidadeDiasCadastrados { get { return Dias.Count; } }
        public decimal MediaDeAmorosidadeNoMes { get { return  Convert.ToDecimal( Dias.Sum(a=>a.Amorosidade))/Dias.Count; } }
        public decimal MediaDeExtroversaoNoMes { get { return Convert.ToDecimal(Dias.Sum(a => a.Extroversao)) / Dias.Count; } }
        public decimal MediaDeFocoNoMes { get { return Convert.ToDecimal(Dias.Sum(a => a.Foco)) / Dias.Count; } }
        public decimal MediaDeEnergiaSexualNoMes { get { return Convert.ToDecimal(Dias.Sum(a => a.EnergiaSexual)) / Dias.Count; } }
        public decimal MediaDeVitalidadeNoMes { get { return Convert.ToDecimal(Dias.Sum(a => a.Vitalidade)) / Dias.Count; } }
        public decimal MediaDeForcaDeAcaoNoMes { get { return Convert.ToDecimal(Dias.Sum(a => a.ForcaDeAcao)) / Dias.Count; } }
        public decimal MediaDeAutoconfiancaProfissionalNoMes { get { return Convert.ToDecimal(Dias.Sum(a => a.AutoconfiancaProfissional)) / Dias.Count; } }
        public decimal MediaDeAutoconfiancaPessoalNoMes { get { return Convert.ToDecimal(Dias.Sum(a => a.AutoconfiancaPessoal)) / Dias.Count; } }

    }
}