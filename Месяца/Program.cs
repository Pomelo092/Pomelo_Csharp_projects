while (true)
{
    Console.WriteLine("Введите номер месяца: ");
    int a = int.Parse(Console.ReadLine());
    switch (a)
    {
        case 1:
            Console.WriteLine("Январь");
            break;
        case 2:
            Console.WriteLine("Февраль");
            break;
        case 3:
            Console.WriteLine("Март");
            break;
        case 4:
            Console.WriteLine("Апрель");
            break;
        case 5:
            Console.WriteLine("Май");
            break;
        case 6:
            Console.WriteLine("Июнь");
            break;
        case 7:
            Console.WriteLine("Июль");
            break;
        case 8:
            Console.WriteLine("Август");
            break;
        case 9:
            Console.WriteLine("Сентябрь");
            break;
        case 10:
            Console.WriteLine("Октябрь");
            break;
        case 11:
            Console.WriteLine("Ноябрь");
            break;
        case 12:
            Console.WriteLine("Декабрь");
            break;

        default:
            Console.WriteLine("Некорректный ввод!");
            break;
    }
}