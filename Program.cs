int numero = 0;
bool e_par = false;

Console.WriteLine("================");
Console.WriteLine("==par ou impar==");
Console.WriteLine("================");

Console.Write("informe um número\t");

numero = Convert.ToInt32(Console.ReadLine()!);

e_par = (numero % 2 == 0);

if (e_par)
{
    Console.WriteLine($"o resultado  {numero} é par");


}
else
{

    Console.WriteLine($"o resultado  {numero} é impar");


}

Console.WriteLine("pressione uma tecla para encerrar");
Console.ReadKey();