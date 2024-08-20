using System;

class Notas
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al sistema de Calculo Notas");
        Console.WriteLine("Favor ingrese su Nombre:");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Favor Ingrese el Nombre de la Asignatura:");
        string Asignatura = Console.ReadLine();
        Console.WriteLine("Ingresa la Primer Nota parcial:");
        int Nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la Segunda Nota parcial:");
        int Nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la Tercer Nota parcial");
        int Nota3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la Cuarta Nota parcial:");
        int Nota4 = Convert.ToInt32(Console.ReadLine());
        int promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

        if (promedio <= 70)
        {
            Console.WriteLine("Usted esta Reprobado");
            Console.ReadLine();
        }
        if (promedio > 70 & promedio <= 80)
        {
            Console.WriteLine("Usted se encuentra en la categoria de bueno.");
            Console.ReadLine();
        }
        if (promedio > 80 & promedio <= 90)
        {
            Console.WriteLine("Usted se encuentra en la categoria de muy bueno.");
            Console.ReadLine();
        }
        if (promedio > 90 & promedio <100)
        {
            Console.WriteLine("Usted es Sobresaliente.");
            Console.ReadLine();
        }

    }
}
