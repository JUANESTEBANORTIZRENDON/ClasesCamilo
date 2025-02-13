using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class Program
{
    static void Main()
    {
        //Gfinicion de variables
        int numeroUsuario;
        int vidas = 10;

        //Gneramos numero random
        int aleatorio = GetRandom();

        while (vidas > 0)
        {
            Console.WriteLine("Vidas: " + vidas);
            //Pedimos datos al usuario
            Console.WriteLine("Porfavor ingresa un numero entre el 1 y el 10 para tratar de adivinar el numero aleatorio");
            numeroUsuario =int.TryParse(Console.ReadLine(), out numeroUsuario) ? numeroUsuario : 0;

            Validacion(aleatorio, numeroUsuario);

            vidas--;
        }

        Console.WriteLine("Perdiste");





        //Gnero el numero random en este metodo 
        static int GetRandom()
        {
            int numeroRandom;
            var random = new Random();
            numeroRandom = random.Next(1, 10);
            return numeroRandom;
        }

        //Mtodo que valida si numero random  es igual al numero ingresado por el usuario y sucesivamente llama otros metodos para validar si es mayor o menor 
        static void Validacion(int aleatorio, int numeroUsuario)
        {
            if (numeroUsuario == aleatorio)
            {
                Console.WriteLine("has encontrado el numero Felicidades");
                Environment.Exit(0);
            }
            else if (numeroUsuario > aleatorio)
            {
                Console.WriteLine("El numero es mayor que el numero a encontrar\nVuelve a intentarlo");
            }
            else
            {
                Console.WriteLine("El numero es menor que el numero a encontrar\nVuelve a intentarlo ");
            }


        }




    }

   
}
