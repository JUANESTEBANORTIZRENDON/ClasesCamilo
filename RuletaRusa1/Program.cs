using System;
using System.Runtime.Serialization.Formatters;

//Definicion de variables 
uint numeroJugador = 0;

int numerorandom = 1;

while(numeroJugador!=numerorandom)
{
    numerorandom = 0;
     numerorandom = GetGeneradorRandom();
    Console.WriteLine("Escribe un numero entre 1 y el 6");
    numeroJugador = uint.TryParse(Console.ReadLine(), out numeroJugador) ? numeroJugador : 0;
    //POR QUE NO CONTINUA EL BUCLE
    Console.WriteLine(numerorandom);
    if(numeroJugador>6 || numeroJugador<1)
    {
        Console.WriteLine("Ingresarte un valor por debajo del rango establecido vuelve a intentarlo");
        
    }

    if (numeroJugador != numerorandom)
    {
        Console.WriteLine("Sobreviviste pasalo al siguiente");
    }
 
}

Console.WriteLine("Perdiste te moriste");

Console.ReadKey();



//metodos
static int GetGeneradorRandom()
{
    ;
    int nuevoRandom;

    var random = new Random();
     nuevoRandom = random.Next(1, 6);


    return nuevoRandom;
}