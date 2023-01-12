// Cria um software de banco, que consiga receber o saldo inicial e o usuário possa fazer as operações de saque e investimento
// no fim mostre o saldo final de acordo com o que for informado pelo usuário

using _13_Tipos_Metodos_Banco;

double saque = 0;
double investimento = 0;
double saldoFinal = 0;
double saldoAtual = 0;
var entrada = "S";

while (entrada == "S")
{
    Console.WriteLine("Digite o seu saldo inicial:");
    double saldo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Deseja realizar algum saque? Digite S para SIM e N para NAO");
    entrada = Console.ReadLine();

    if (entrada == "S")
    {
        Console.WriteLine("Digite o valor para saque:");
        saque = Convert.ToDouble(Console.ReadLine());
    }

    Console.WriteLine("Deseja realizar algum investimento? Digite S para SIM e N para NAO");
    entrada = Console.ReadLine();

    if (entrada == "S")
    {
        Console.WriteLine("Digite o valor para investir:");
        investimento = Convert.ToDouble(Console.ReadLine());
    }

    if (saldo != 0)
    {
        saldoAtual = Calculadora.Sacar(saldo, saque);
    }
  
    if (saldo != 0)
    {
        saldoFinal = Calculadora.Investir(saldoAtual, investimento);
    }

    if (saldoFinal <= -0)
    {
        Console.WriteLine("Seu saldo está negativo, não é possivel realizar o saque e investimento");
    }

    if (saldoFinal >= 0)
    {
        Console.WriteLine("Seu saldo final é: " + saldoFinal);
    }
    
    Console.WriteLine();
    Console.WriteLine("Deseja realizar mais alguma operação? Digite S para SIM e N para NÃO");
    entrada= Console.ReadLine();

}



