Console.Clear();

double tempo;

Console.WriteLine("--- Raio e trovão ---");

ReceberValor();
double converter = tempo * 340.29;
ExibirValor();

void ReceberValor()
{
    Console.Write("\nDigite o tempo em segundos entre o raio e o trovão: ");
    tempo = Convert.ToDouble(Console.ReadLine());
}

void ExibirValor()
{
    Console.WriteLine($"\nA distância entre você e o raio é de: {converter / 1000:N5}km");
}