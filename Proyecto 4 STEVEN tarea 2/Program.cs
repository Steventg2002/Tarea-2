
bool condition = true;
int cont = 0;
Console.WriteLine("ingrese un numero");
int limite = int.Parse(Console.ReadLine());

while (condition)

    if (cont == limite)
        condition = false;
cont++;
Console.WriteLine(cont);
