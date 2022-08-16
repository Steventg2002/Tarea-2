
Console.WriteLine("ingrese su nota promedio:");
double nota = double.Parse(Console.ReadLine());

if (nota >= 0 && nota <= 10)

    if (nota >= 6.0)

        Console.WriteLine("Aprovado");

    else if (nota >= 5.0)

        Console.WriteLine("Reposicion");

    else

        Console.WriteLine("Reprobado");

else

    Console.WriteLine("Nota invalida");