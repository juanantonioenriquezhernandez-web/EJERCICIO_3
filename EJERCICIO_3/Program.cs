using System.ComponentModel.Design;

Console.WriteLine("EJERCICIO_1");                                    //#1
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");    //Promedio en 3 calificaciones
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola

Console.Write("Ingrese la primera calificación: ");
double calificacion1 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 1

Console.Write("Ingrese la segunda calificación: ");
double calificacion2 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 2

Console.Write("Ingrese la tercera calificación: ");
double calificacion3 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 3 

double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0;  // se toma en cuenta la suma con la division de ellas para determinar el promedio de las tres calificaciones

Console.WriteLine();
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}");  //se imprime el promedio en la consola, con dos decimales de precisión
//d}Determine si el promedio aprobo o no 
if (promedio > 70)// se deterina que si el promedio es mayor a 70, el alumno es aprobado, de lo contrario es reprobado
{
    Console.WriteLine("El Alumno es aprobado");// doy a conocer que el alumno es aprobado
}
else
{
    Console.WriteLine("El Alumno es reprobado");// en caso de que el promedio sea menor a 70, se da a conocer que el alumno es reprobado
}
if (promedio <= 50)
{
    Console.WriteLine("El Alumno es deficiente");
}
else if (promedio < 69 && promedio > 51)
{
    Console.WriteLine("El Alumno requiere apoyo");
}
else if (promedio < 79 && promedio > 51)
{
    Console.WriteLine("El Alumno es regular");
}
else if (promedio < 89 && promedio > 80)
{
    Console.WriteLine("El Alumno es bueno");
}
else if (promedio < 100 && promedio > 90)
{
    Console.WriteLine("El Alumno es excelente");
}