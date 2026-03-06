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

//Valor da compra:
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


//Verificando saldo na conta:
/*Console.Write("Digite o saldo na sua conta: ");
decimal saldo = decimal.Parse(Console.ReadLine());

if (saldo > 0)
{
    Console.WriteLine("Saldo positivo!");
}
else
{
    Console.WriteLine("Saldo negativo!");
}
*/


//Classificação de produtos:
/*Console.Write("Digite o código do produto (1 ou 2): ");
int codigo = int.Parse(Console.ReadLine());

if (codigo == 1)
{
    Console.WriteLine("O produto é peresível");
} 
else if (codigo == 2)
{
    Console.WriteLine("O produto é não peresível");
}
else
{
    Console.WriteLine($"Você digitou o código {codigo}, esse código é inválido!1");
}
*/


//Classificando a nota de um aluno:
/*Console.Write("Digite a nota final do aluno: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 9)
{
    Console.WriteLine("O aluno recebeu nota A");
}
else if (nota >= 7 && nota < 9)
{
    Console.WriteLine("O aluno recebeu nota B");
}
else if (nota >= 5 && nota < 7)
{
    Console.WriteLine("O aluno recebeu nota C");
}
else
{
    Console.WriteLine("O aluno recebeu nota D");
}
*/


//Verificando acessoa área restrita:
/*int senha = 1234;
Console.Write("Digite a senha: ");
int senhaDigitada = int.Parse(Console.ReadLine());

Console.Write("Digite o nível de acesso: ");
int nivelAcesso = int.Parse(Console.ReadLine());

if (senha == senhaDigitada && nivelAcesso >= 5)
{
    Console.WriteLine("Acesso liberado");
}
else
{
    Console.WriteLine("Acesso negado");
}
*/


//Classificando a faixa etária
/*Console.Write("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());
Console.Clear();

if (idade <= 12)
{
    Console.WriteLine("Classificação: Infatil");
}
else if (idade >= 13 && idade <= 17)
{
    Console.WriteLine("Classificação: Adolescente");
}
else if (idade >= 18 && idade <= 59)
{
    Console.WriteLine("Classificação: Adulto");
}
else
{
    Console.WriteLine("Classificação: Idoso");
}
*/


//Switch - case:
/*Console.WriteLine("\nMENU:");
Console.WriteLine("1 - Ver produtos");
Console.WriteLine("2 - Fazer pedido");
Console.WriteLine("0 - Sair");
Console.Write("Escolha uma opção: ");

int opcao = int.Parse(Console.ReadLine());

Console.Clear();

switch (opcao)
{
    case 1:
    Console.WriteLine("Mostrando produtos...");
    break;
    case 2:
    Console.WriteLine("Pedido realizado");
    break;
    case 0:
    Console.WriteLine("Saindo...");
    break;
    default:
    Console.WriteLine("Opação inválida");
    break;
}
*/


//Calculadora de operações básicas:
/*Console.WriteLine("\nMenu: ");
Console.Write("Digite o primeiro número: ");
int primeiroNumero = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int segundoNumero = int.Parse(Console.ReadLine());

Console.Write("Digite a operação (+, -, * e /): ");
string operacao = Console.ReadLine();

switch(operacao)
{
    case "+":
    Console.WriteLine("Resultado: " + (primeiroNumero + segundoNumero));
    break;

    case "-":
    Console.WriteLine("Resultado: " + (primeiroNumero - segundoNumero));
    break;

    case "*":
    Console.WriteLine("Resultado: " + (primeiroNumero * segundoNumero));
    break;

    case "/":
    Console.WriteLine("Resultado: " + (primeiroNumero / segundoNumero));
    break;

    default:
    Console.WriteLine("Operação inválida");
    break;
}*/


//Saudação personalizada:
/*Console.WriteLine("1 - Manhã");
Console.WriteLine("2 - Tarde");
Console.WriteLine("3 - Noite");
Console.Write("\nQue momento do dia é agora?: ");
int momentoDia = int.Parse(Console.ReadLine());

Console.Write("Qual o seu nome?: ");
string nome = Console.ReadLine();

switch(momentoDia)
{
    case 1:
    Console.WriteLine($"Bom dia, {nome}");
    break;

    case 2:
    Console.WriteLine($"Boa tarde, {nome}");
    break;

    case 3:
    Console.WriteLine($"Boa noite, {nome}");
    break;

    default:
    Console.WriteLine("Opção inválida");
    break;
}
*/


//Sistema de recompensa:
/*Console.Write("Digite o código de recompensa (Dobrar, Curar, Ouro, Especial): ");
string codigo = Console.ReadLine();

string mensagem = codigo switch
{
    "Dobrar" => "Você ganhou 2x EXP por 1 hora",
    "Curar" => "Poção de cura adquirida!",
    "Ouro" => "+1000 moedas de ouro!",
    "Especial" => "Item lendário desbloqueado!",
    _ => "Recompensa indisponível."
};

Console.WriteLine(mensagem);
*/


//Refatorando a organização de livros:
/*Console.WriteLine("Digite o código do livro: ");
int codigo = int.Parse(Console.ReadLine());
 
switch (codigo / 100)
{
    case 1:
        Console.WriteLine("Ficção Científica");
        break;
    case 2:
        Console.WriteLine("Literatura Clássica");
        break;
    case 3:
        Console.WriteLine("Fantasia");
        break;
    case 4:
        Console.WriteLine("Romance");
        break;
    case 5:
        Console.WriteLine("Suspense/Mistério");
        break;
    case 6:
        Console.WriteLine("Não Ficção");
        break;
    case 7:
        Console.WriteLine("Biografias/Memórias");
        break;
    case 8:
        Console.WriteLine("Distopia");
        break;
    case 9:
        Console.WriteLine("Infantojuvenil");
        break;
    default:
        Console.WriteLine("Código inexistente");
        break;
}
*/


//Autentificação de usuário:
/*string ADMIN_USER = "Admin";
 
Console.WriteLine("Sistema de Autenticação");
Console.WriteLine("-----------------------");
Console.Write("Digite seu nome de usuário: ");
 
string username = Console.ReadLine();
 
if (username == ADMIN_USER)
{
    Console.WriteLine($"Bem-vindo, {username}!");
}
 
else
{
    Console.WriteLine("Usuário não cadastrado.");
    Console.WriteLine("Opções disponíveis:");
    Console.WriteLine("[1] Cadastrar novo usuário");
    Console.WriteLine("[2] Acessar como convidado");
    Console.WriteLine("[3] Sair");
 
    int opcao = int.Parse(Console.ReadLine());
 
    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Novo usuário '{username}' cadastrado com sucesso!");
            break;
 
        case 2:
            Console.WriteLine("Acesso concedido como convidado.");
            break;
 
        case 3:
            Console.WriteLine("Saindo do sistema...");
            Environment.Exit(0);
            break;
 
        default:
            Console.WriteLine("Opção inválida. O sistema será encerrado.");
            break;
    }
}
*/