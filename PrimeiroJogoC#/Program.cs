int numeroSecreto = 42;

do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns!, Você acertou o número.");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("Número secreto é maior.");

    }
    else
    {
        Console.WriteLine("Número secreto é menor");
    }
}
while (true);