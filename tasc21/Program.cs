// Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между ними в
//3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84;
//A (7,-5,0); B (1,-1,9) -> 11.53

int x = ReadInt("Введите координаты х для точки A: ");
int y = ReadInt("Введите координаты y для точки A: ");
int z = ReadInt("Введите координаты z для точки A: ");
int x1 = ReadInt("Введите координаты х для точки B: ");
int y1 = ReadInt("Введите координаты y для точки B: ");
int z1 = ReadInt("Введите координаты z для точки B: ");

int A = x1 - x;
int B = y1 - y;
int C = z1 - z;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Расстояние между точками A и B = " + length);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

