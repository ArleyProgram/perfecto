void facto()
{
    Console.WriteLine("ingrese un numero: ");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = 1;
    for ( int i = y; i<=x; i++)
    {
        int z = i * y;
        y = z;
    }
    Console.WriteLine($"el factorial de {x} es {y}");
}
facto();
