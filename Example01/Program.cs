Console.WriteLine("Мы попали в игру угадай число");
int secret_number = new Random().Next(1, 11);
int attempt = 5;
bool Win = false;
while (attempt > 0)
{
    Console.WriteLine("Введите число от 1 до 10");
    int user_number = int.Parse(Console.ReadLine());
    if (user_number > secret_number)
    {
        Console.WriteLine("Секретное число меньше");
        attempt--;
    }
    else if (user_number < secret_number)
    {
        Console.WriteLine("Секретное число больше");
        attempt--;
    }
    else if (user_number == secret_number)
    {
        Console.WriteLine("Мы угадали");
        Win = true;
        break;
    }
    Console.WriteLine("По-пробуй еще раз, осталось " + attempt + " попытки");
}
if (Win)
{
    Console.WriteLine("Вы победили приходи еще");
    Console.WriteLine("Осталось попыток " + (attempt - 1));
}
else
{
    Console.WriteLine("Вы проиграли, секретное число " + secret_number);
    System.Console.WriteLine("По-пробуйте еще раз");
}