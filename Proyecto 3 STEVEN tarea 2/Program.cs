﻿
Console.WriteLine("Ingrese el numero a evaluar:");
int multiplo = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el numero del limite:");
int limite = int.Parse(Console.ReadLine());

for (int i = 0; i <= limite; i++)

    if (i %multiplo == 0)

        Console.Write(1 + " ");
    
