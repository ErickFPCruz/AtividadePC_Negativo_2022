Console.Clear();

int numero;

Console.Write("Escreva um número qualquer: ");
numero = Convert.ToInt32(Console.ReadLine());

bool numeroEhNegativo = numero < 0;

if (numeroEhNegativo)
{
    Console.WriteLine("Você escreveu um número inteiro negativo!");
}
Console.WriteLine();