
Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1,101);

do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("O jogo acabou, você acertou o número secreto!");
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