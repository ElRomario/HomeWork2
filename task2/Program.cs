/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

double distance(double[] Xarray, double[] Yarray)
{
    return Math.Sqrt(Math.Pow(Yarray[0] - Xarray[0], 2) + Math.Pow(Yarray[1] - Xarray[1], 2) + Math.Pow(Yarray[2] - Xarray[2], 2));
}

double[] dotsInit(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i <= 2; i++)
    
    {
        array[i] = rnd.Next(0, 10) ;

    }
    return array;
}
double[] Yarray = new double[3];
double[] Xarray = new double[3];
dotsInit(Xarray);
dotsInit(Yarray);

Console.WriteLine($"Расстояние между Точками X и Y ={Math.Round(distance(Xarray, Yarray), 2)}");

