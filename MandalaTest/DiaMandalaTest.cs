using System;
using System.Collections.Generic;
using System.Linq;
using Mandala.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MandalaTest
{
    [TestClass]
    public class DiaMandalaTest
    {
        [TestMethod]
        public void TestaDiaMandalaSemDataDefinida()
        {
            string validacaoEsperada = "A data deve ser preenchida.";

            DiaMandala dm = new DiaMandala();


            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComExtroversaoMenorQue0()
        {
            string validacaoEsperada = "O nível de extroversão deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.Extroversao = -1;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComExtroversaoMaiorQue10()
        {
            string validacaoEsperada = "O nível de extroversão deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.Extroversao = 11;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComFocoMenorQue0()
        {
            string validacaoEsperada = "O nível de Foco deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.Foco = -1;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComFocoMaiorQue10()
        {
            string validacaoEsperada = "O nível de Foco deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.Foco = 11;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComEnergiaSexualMenorQue0()
        {
            string validacaoEsperada = "O nível de energia sexual deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.EnergiaSexual = -1;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComEnergiaSexualMaiorQue10()
        {
            string validacaoEsperada = "O nível de energia sexual deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.EnergiaSexual = 11;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComVitalidadeMenorQue0()
        {
            string validacaoEsperada = "O nível de vitalidade deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.Vitalidade = -1;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComVitalidadeMaiorQue10()
        {
            string validacaoEsperada = "O nível de vitalidade deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.Vitalidade = 11;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComAmorosidadeMenorQue0()
        {
            string validacaoEsperada = "O nível de amorosidade deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.Amorosidade = -1;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComAmorosidadeMaiorQue10()
        {
            string validacaoEsperada = "O nível de amorosidade deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.Amorosidade = 11;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }
        
        [TestMethod]
        public void TestaDiaMandalaComForcaDeAcaoMenorQue0()
        {
            string validacaoEsperada = "O nível de força de ação deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.ForcaDeAcao = -1;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComForcaDeAcaoMaiorQue10()
        {
            string validacaoEsperada = "O nível de força de ação deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.ForcaDeAcao = 11;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComAutoconfiancaPessoalMenorQue0()
        {
            string validacaoEsperada = "O nível de autoconfiança pessoal deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.AutoconfiancaPessoal = -1;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComAutoconfiancaPessoalMaiorQue10()
        {
            string validacaoEsperada = "O nível de autoconfiança pessoal deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.AutoconfiancaPessoal = 11;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }
        
        [TestMethod]
        public void TestaDiaMandalaComAutoconfiancaProfissionalMenorQue0()
        {
            string validacaoEsperada = "O nível de autoconfiança profissional deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.AutoconfiancaProfissional = -1;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaComAutoconfiancaProfissionalMaiorQue10()
        {
            string validacaoEsperada = "O nível de autoconfiança profissional deve estar entre 0 e 10.";

            DiaMandala dm = new DiaMandala();

            dm.AutoconfiancaProfissional = 11;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsFalse(ehValida);
            Assert.IsTrue(validacoesEncontradas.Any(a => a == validacaoEsperada));
        }

        [TestMethod]
        public void TestaDiaMandalaValida()
        {
            DiaMandala dm = new DiaMandala();

            dm.Data = DateTime.Today;
            dm.Amorosidade = 10;
            dm.AutoconfiancaPessoal = 10;
            dm.AutoconfiancaProfissional = 10;
            dm.EnergiaSexual = 10;
            dm.Extroversao = 10;
            dm.Foco = 10;
            dm.ForcaDeAcao = 10;
            dm.Vitalidade = 10;

            List<string> validacoesEncontradas;
            var ehValida = dm.Validar(out validacoesEncontradas);

            Assert.IsTrue(ehValida);
            Assert.IsTrue(!validacoesEncontradas.Any());
        }


    }
}
            
