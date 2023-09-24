string a;
Console.WriteLine("Введите день недели");
a = Convert.ToString(Console.ReadLine());
switch (a)
{
    case "Понедельник":
    case "понедельник":
        Console.WriteLine(1); break;
    case "Вторник":
    case "вторник":
        Console.WriteLine(2); break;
    case "Среда":
    case "среда":
        Console.WriteLine(3); break;
    case "Четверг":
    case "четверг":
        Console.WriteLine(4); break;
    case "Пятница":
    case "пятница":
        Console.WriteLine(5); break;
    case "Суббота":
    case "суббота":
        Console.WriteLine(6); break;
    case "Воскресенье":
    case "воскресенье":
        Console.WriteLine(7); break;
}
Console.ReadKey();