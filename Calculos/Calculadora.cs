namespace Calculos
{

    public class Calculadora
    {

        public int Soma(int operador1, int operador2) => operador1 + operador2;

        public int Subtracao(int operador1, int operador2) => operador1 - operador2;

        public int Multiplicao(int operador1, int operador2) => operador1 * operador2;

        public int Divisao(int dividendo, int divisor)
        {

            if (divisor != 0)
            {

                return dividendo / divisor;

            }
            else
            {

                return 0;

            }

        }

        public (int quociente, int resto) RestoDivisao(int dividendo, int divisor) => (dividendo / divisor, dividendo % divisor);
    }
}

