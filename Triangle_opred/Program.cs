while (true)
{
    Console.WriteLine("Введите первую сторону треугольника: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите вторую сторону треугольника: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите третью сторону треугольника: ");
    int c = int.Parse(Console.ReadLine());

    if (a == b && b == c)
    {
        Console.WriteLine("Равносторонний");
    }
    else if (a == b && b != c || b == c && c != a || c == a && a != b)
    {
        Console.WriteLine("Равнобедренный");
    }
    else 
    {
        Console.WriteLine("Разносторонний");
    }
}