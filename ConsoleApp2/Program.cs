double[]salarios = new double[10];
string? j;
double maiorSal = 0;
for (int i = 0; i < salarios.Length; i++)
{
    Console.Write((i+1)+"º salário:");
    j = Console.ReadLine();
    Double.TryParse(j, out salarios[i]);
    if (salarios[i] > maiorSal)
    {
        maiorSal = salarios[i];
    }
}
Console.Write("Maior salário: R$" + maiorSal.ToString("0.00"));