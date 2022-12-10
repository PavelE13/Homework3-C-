/* Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Метод проверки вводимых данных
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
            return result;
        else
            Console.WriteLine("Вы ввели не число");
    }
    return result;
}

//Метод расчета расстояния в 3D
double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return result;
}

int numx1 = GetNumber("Введите координаты точки 1:X1= ");
int numy1 = GetNumber("                           Y1= ");
int numz1 = GetNumber("                           Z1= ");
int numx2 = GetNumber("Введите координаты точки 2:Х2= ");
int numy2 = GetNumber("                          :Y2= ");
int numz2 = GetNumber("                          :Z2= ");
double dist = Distance3D(numx1, numy1, numz1, numx2, numy2, numz2);
Console.WriteLine($"Расстояние между точкой 1 [{numx1},{numy1},{numz1}] и 2 [{numx2},{numy2},{numz2}] = {dist} ");