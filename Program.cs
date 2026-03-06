/*bool conexaoAtiva = true;

if (conexaoAtiva)
{
    Console.WriteLine("Iniciando o jogo!");
}
else
{
    Console.WriteLine("Conexão Perdida!");
}
*/


/*Console.Write("Digite o valor da sua compra: ");
double valorCompra = double.Parse();

bool clienteVip = true;

if (valorCompra > 300.00 && clienteVip)
{
    double desconto = valorCompra * 0.1;
    Console.WriteLine($"Você ganhou {desconto} reais em desconto!");
} else if (valorCompra > 200.00)
{
    Console.WriteLine("Você ganhou um brinde!");
}
else
{
    double diferenca = 300.00 - valorCompra;
    Console.WriteLine($"Faltam {diferenca} reais para ganhar o desconto!");
}
*/


Console.Write("Digite o saldo na sua conta: ");
decimal saldo = decimal.Parse(Console.ReadLine());

if (saldo > 0)
{
    Console.WriteLine("Saldo positivo!");
}
else
{
    Console.WriteLine("Saldo negativo!");
}