int contador, numero;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("===BEM VINDO A CALCULADORA!===\n");
Thread.Sleep(2000);
Console.ResetColor();

Console.WriteLine("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(" ");

contador = 0;

if(numero <= 0){
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Digite outro número.");
    Console.ResetColor();

}
else{
    Console.WriteLine($"Número Selecionado: {numero}");
    while (contador <= 10){
        int resultado = contador * numero;

        Console.WriteLine($"{numero} * {contador++} = {resultado}");

    }
    Console.WriteLine(" ");
}