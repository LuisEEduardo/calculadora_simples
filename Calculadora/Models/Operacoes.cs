namespace Calculadora.Models
{
    public delegate int Calcular(int valor1, int valor2);

    public class Operacoes
    {
        public int Somar(int valor1, int valor2)
            => valor1 + valor2;

        public int Subtrair(int valor1, int valor2)
            => valor1 - valor2;

        public int Multiplicar(int valor1, int valor2)
            => valor1 * valor2;

        public int Divisao(int valor1, int valor2)
            => valor1 / valor2;
    }
}
