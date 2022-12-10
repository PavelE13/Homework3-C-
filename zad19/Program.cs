/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// Метод проверки вводимых данных
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 10000 && result < 99999)
            return result;
        else
            Console.WriteLine("Вы ввели не 5-ти значное число");
    }
    return result;
}

//Метод проверки на палиндром
void CheckNumber(int number)
{
    string strnum = number.ToString();
    if (strnum[0] == strnum[4] && strnum[1] == strnum[3])
        Console.WriteLine($"Число {strnum} палиндром!");
    else Console.WriteLine($"Число {strnum} не палиндром!");
}

int num = GetNumber("Введите 5-ти значное число: ");
CheckNumber(num);