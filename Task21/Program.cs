// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

static int[] Input()
{
    int[] Array = new int[3];
    Console.Write("Введите значение X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение Z: ");
    int z = Convert.ToInt32(Console.ReadLine());
    Array[0] = x;
    Array[1] = y;
    Array[2] = z;
    return Array;
}

static void Main(){
    Console.WriteLine("Напишите программу, которая принимает на вход координаты \nдвух точек и находит расстояние между ними в 3D пространстве.");
    Console.WriteLine("\nКоординаты 1-ой точки");
    int[] index1 = Input();
    Console.WriteLine("\nКоординаты 2-ой точки");
    int[] index2 = Input();
    double data = Math.Sqrt(Math.Pow(index2[0]-index1[0], 2)+Math.Pow(index2[1]-index1[1], 2)+Math.Pow(index2[2]-index1[2], 2));
    Console.WriteLine("\nРасстояние между точками в 3D пространстве: " + Math.Round(data, 2));
}
Main();