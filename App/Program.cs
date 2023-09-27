using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main()
    {
      // INVOCA FUNÇÕES SEPARADAMENTE

      // MediaAritmetica();
      // CalcularDezPorcento();
      // FahrenheitParaGraus();
      // JurosComposto();
      // SalarioBruto();
      // Logaritmo();
      // SalarioVendedor();
      // TotalDeRodas();
      // QueHorasSao();
      // Medias();
    }

    static void MediaAritmetica(double value1, double value2, double media) {

      Console.Write("Digite valor 1: ");
      value1 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Digite valor 2: ");
      value2 = Convert.ToDouble(Console.ReadLine());

      media = (value1 + value2) / 2;

      Console.WriteLine($"A média dos números {value1} e {value2} é: {media}");
    }

    static void CalcularDezPorcento () {
      Console.Write("Digite o preço do produto: ");

      double inputValue = Convert.ToDouble(Console.ReadLine());

      double newValue = inputValue + (inputValue * 0.10);

      Console.WriteLine($"O valor do produto com 10% de acréscimo é: {newValue:C}");
    }

    static void FahrenheitParaGraus () {
      Console.Write("Digite a temperatura: ");

      double temperaturaGraus = (Convert.ToDouble(Console.ReadLine()) - 32) / 1.8;

      Console.WriteLine($"A temperatura em graus é: {Math.Round(temperaturaGraus, 1)}ºC");
    }

    static void JurosComposto () {

      Console.Write("Qual o capital aplicado: ");
      double capital = Convert.ToDouble(Console.ReadLine());

      Console.Write("Qual a taxa de juros (%): ");
      double i = Convert.ToDouble(Console.ReadLine()) / 100;

      Console.Write("Qual o prazo de aplicação em meses: ");
      int n = Convert.ToInt32(Console.ReadLine());

      double montante = capital * Math.Pow(1 + i, n); 

      Console.WriteLine($"O seu montante final será {montante:C}");
    }

    static void SalarioBruto () {
        Console.Write("Digite o número de horas trabalhadas no mês: ");
        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor recebido por hora de trabalho: ");
        double valorPorHora = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor do salário família: ");
        double salarioFamilia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o número de filhos com idade menor que 14 anos: ");
        int numeroFilhos = Convert.ToInt32(Console.ReadLine());

        double salarioBruto = horasTrabalhadas * valorPorHora + salarioFamilia * numeroFilhos;

        Console.WriteLine($"O salário bruto a ser recebido é: {salarioBruto:C}");
    }

    static void Logaritmo () {
      Console.Write("Digite o número: ");
      double numero = Convert.ToDouble(Console.ReadLine());

      Console.Write("Base do logaritmo: ");
      double baseLog= Convert.ToDouble(Console.ReadLine());

      double resultado = Math.Log(numero, baseLog);

      Console.WriteLine($"O logaritmo de {numero} na base {baseLog} é: {resultado}");
    }

    static void SalarioVendedor () {
      Console.Write("Digite o salário bruto: ");
      double salariobruto = Convert.ToDouble(Console.ReadLine());

      Console.Write("Digite o valor total das vendas: ");
      double valorVendas = Convert.ToDouble(Console.ReadLine());

      Console.Write("Percentual recebido das vendas (%): ");
      double percentual = Convert.ToDouble(Console.ReadLine());

      double salarioTotal = salariobruto + (valorVendas / 100) * percentual;

      Console.WriteLine($" O salário total é de: {salarioTotal:C}");
    }

    static void TotalDeRodas () {
      Console.Write("Quantos carros: ");
      double carros = Convert.ToDouble(Console.ReadLine()) * 4;

      Console.Write("Quantas motos: ");
      double motos = Convert.ToDouble(Console.ReadLine()) * 2;

      Console.WriteLine($"O total de rodas é {carros + motos}");
    }

    static void QueHorasSao () {
      Console.Write("Digite os segundos: ");
      int totalSegundos = Convert.ToInt32(Console.ReadLine());

        int horas = totalSegundos / 3600;
        int minutos = (totalSegundos % 3600) / 60;
        int segundos = totalSegundos % 60;

        Console.WriteLine($"Horas: {horas}, Minutos: {minutos}, Segundos: {segundos}");
    }

    static void Medias () {
        Console.Write("Digite o primeiro valor: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o terceiro valor: ");
        double valor3 = Convert.ToDouble(Console.ReadLine());

        double mediaAritmetica = (valor1 + valor2 + valor3) / 3;

        double mediaHarmônica = 3 / ((1 / valor1) + (1 / valor2) + (1 / valor3));

        double mediaGeometrica = Math.Pow((valor1 * valor2 * valor3), 1.0 / 3);

        Console.WriteLine($"Média Aritmética: {mediaAritmetica}");
        Console.WriteLine($"Média Harmônica: {mediaHarmônica}");
        Console.WriteLine($"Média Geométrica: {mediaGeometrica}");
    }
};
