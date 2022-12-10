/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
кубов чисел от 1 до N.
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125*/

// Метод проверки вводимых данных
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
            return result;
        else
            Console.WriteLine("Вы ввели не правильное число");
    }
    return result;
}

void TableCubNum(int num)
{
    if (num > 0) for (int i = 1; i <= num; i++) Output(i);
    else for (int i = num; i <= 1; i++) Output(i);
}

//Вывод данных
void Output(int i)
{
    Console.WriteLine($"{i} в кубе = {Math.Pow(i, 3)}");
    return;
}

int num = GetNumber("Введите целое число (не 0): ");
TableCubNum(num);