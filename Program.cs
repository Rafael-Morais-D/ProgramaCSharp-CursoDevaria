const string textoOlaMundo = "Olá mundo! Este é meu primeiro programa em C#, meu nome é";
string nomeCompleto;
int idade;

/* idade = 31;
nomeCompleto = "Rafael Morais";
nomeCompleto = "Nome Mudado"; */

Console.WriteLine("Qual o seu nome completo?");

nomeCompleto = Console.ReadLine().ToString();

Console.WriteLine("Quantos anos você tem?");

idade = Convert.ToInt32(Console.ReadLine());

string fraseCompleta = $"{textoOlaMundo} {nomeCompleto} e eu tenho {idade} anos!";

Console.WriteLine(fraseCompleta);