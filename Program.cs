/* DECLARAÇÂO DE VARIÁVEIS E CONSTANTES E OPERADOR AND COM IF E SWITCH CASE */

/* const string textoOlaMundo = "Olá mundo! Este é meu primeiro programa em C#, meu nome é";
string nomeCompleto;
int idade;

Console.WriteLine("Qual o seu nome completo?");

nomeCompleto = Console.ReadLine().ToString();

Console.WriteLine("Quantos anos você tem?");

idade = Convert.ToInt32(Console.ReadLine());

string fraseCompleta = $"{textoOlaMundo} {nomeCompleto} e eu tenho {idade} anos!";

if (idade == 31 && nomeCompleto == "Rafael Morais")
{
    Console.WriteLine($"{fraseCompleta} Você é proprietário desse computador.");
}
else
{
    Console.WriteLine($"{fraseCompleta} Parabéns, mas você não é proprietário desse computador.");
}

switch (nomeCompleto)
{
    case "Rafael Morais": Console.WriteLine($"{fraseCompleta} Você é proprietário desse computador."); break;
    default: Console.WriteLine($"{fraseCompleta} Parabéns, mas você não é proprietário desse computador."); break;
} */


/* OPERADOR OR COM IF */

/* string fastFood;

Console.WriteLine("O que vamos jantar hoje?");

fastFood = Console.ReadLine().ToString();

if (fastFood == "Pizza" || fastFood == "Hamburger")
{
    Console.WriteLine($"Oba, adoro comer {fastFood}");
}
else
{
    Console.WriteLine($"Legal, mas preferia Pizza");
} */


/* VARIÁVEIS E OPERADOR UNÁRIO */

/* idade = 31;
nomeCompleto = "Rafael Morais";
nomeCompleto = "Nome Mudado"; 

bool valido = true;
Console.WriteLine(!valido);
Console.WriteLine(valido); */


/* DESAFIO */

string nomeJogador;

Console.WriteLine("Qual o nome do jogador?");

nomeJogador = Console.ReadLine().ToString();

switch (nomeJogador)
{
    case "Rafael": case "Rodrigo": case "Renata": case "Miriam": case "Newton": case "Aida": case "Fabiana": case "Leandro":
        Console.WriteLine("Jogador autorizado");
        break;
    default:
        Console.WriteLine("Jogador não autorizado");
        break;
}