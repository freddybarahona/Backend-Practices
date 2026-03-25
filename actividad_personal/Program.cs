// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hola Freddy");
Console.WriteLine("Ingresa tu nombre:");

var nombre = Console.ReadLine();

if (string.IsNullOrEmpty(nombre))
{
    Console.WriteLine("Nombre inválido");
}
else
{
    Console.WriteLine($"Hola {nombre}");
}*/

//--------------------CREACION CALCULADORA------------------------

using actividad_personal.clases;
public class Calculadora : Computadora
{
    public void Divi(int a, int b)
    {
        Console.WriteLine(a / b);
    }

    public void Multi(int a, int b)
    {
        Console.WriteLine(a * b);
    }

    public void Resta(int a, int b)
    {
        Console.WriteLine(a - b);
    }

    public void Suma(int a, int b)
    {
        Console.WriteLine(a + b);
    }
}


Computadora calc = new Calculadora();

Console.WriteLine("Ingresa numero 1");
var inp1=Console.ReadLine();
Console.WriteLine("Ingresa numero 1");
var inp2=Console.ReadLine();