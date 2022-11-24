/*Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int xA = ReadInt("Введите координату x точки A: ");
int yA = ReadInt("Введите координату y точки A: ");
int zA = ReadInt("Введите координату z точки A: ");
int xB = ReadInt("Введите координату x точки B: ");
int yB = ReadInt("Введите координату y точки B: ");
int zB = ReadInt("Введите координату z точки B: ");

int sqrSideX = (xA - xB) * (xA - xB);
int sqrSideY = (yA - yB) * (yA - yB);
int sqrSideZ = (zA - zB) * (zA - zB);
double distance = Math.Sqrt(sqrSideX + sqrSideY + sqrSideZ);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
