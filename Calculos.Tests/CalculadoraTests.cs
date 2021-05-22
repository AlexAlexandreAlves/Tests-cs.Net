using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculos.Tests
{

    [TestClass]

    public class CalculadoraTests
    {

        [TestMethod]
        public void Soma_DeveRetornarOValorCorreto()

        {

            Calculadora c = new Calculadora();

            var resultado = c.Soma(10, 20);

            //Verifica se o resultado é igual a 30

            Assert.AreEqual(30, resultado);

        }

        [TestMethod]
        public void Divisao_DeveRetornarOValorCorreto()

        {

            Calculadora c = new Calculadora();

            var resultado = c.Divisao(100, 10);

            //Verifica se o resultado é igual a 10

            Assert.AreEqual(10, resultado);

        }

        [TestMethod]

        public void Divisao_DividePorUm()

        {

            Calculadora c = new Calculadora();

            var resultado = c.Divisao(10, 1);

            //Verifica se o resultado é igual a 10

            Assert.AreEqual(10, resultado);

        }

        [TestMethod]

        public void Divisao_DividePorZero()

        {

            Calculadora c = new Calculadora();

            var resultado = c.Divisao(1, 0);

            //Verifica se o resultado é igual a 10

            Assert.AreEqual(0, resultado);

        }

         [TestMethod]

        public void Divisao_ResultaFracao()

        {

            Calculadora c = new Calculadora();

            var resultado = c.Divisao(1, 10);

            //Verifica se o resultado é igual a 10

            Assert.AreEqual(0.1, resultado);

        }


    }
}
