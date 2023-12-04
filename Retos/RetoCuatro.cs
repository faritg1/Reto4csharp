using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaPushUp.Retos
{
    public class RetoCuatro
    {
        public void reto4(){
        while (true)
        {
            Console.Clear();
            Console.Write("Ingrese la cantidad de universidades que participan en el proceso: ");
            int cantidadUniversidades = int.Parse(Console.ReadLine());

            int universidadesAceptan = 0;
            int universidadesRechazan = 0;
            int universidadesEmpate = 0;

            for (int i = 0; i < cantidadUniversidades; i++)
            {
                Console.Write("Ingrese el nombre de la universidad: ");
                string nombreUniversidad = Console.ReadLine();

                int votosA = 0;
                int votosR = 0;
                int votosN = 0;
                int votosB = 0;

                while (true)
                {
                    Console.WriteLine("Ingrese el voto de un alumno (A, R, N, B) o X para terminar\n");
                    string voto = Console.ReadLine();

                    if (voto == "A" || voto == "a")
                    {
                        votosA++;
                    }
                    else if (voto == "R" || voto == "r")
                    {
                        votosR++;
                    }
                    else if (voto == "N" || voto == "n")
                    {
                        votosN++;
                    }
                    else if (voto == "B" || voto == "b")
                    {
                        votosB++;
                    }
                    else if (voto == "X" || voto == "x")
                    {
                        break;
                    }
                }

                Console.Write($"{nombreUniversidad}: {votosA} Aceptan, {votosR} Rechazan, {votosB} Blancos, {votosN} Nulos\n");

                if (votosA > votosR)
                {
                    universidadesAceptan++;
                }
                else if (votosR > votosA)
                {
                    universidadesRechazan++;
                }
                else
                {
                    universidadesEmpate++;
                }
            }

            Console.WriteLine("Universidades que aceptan: " + universidadesAceptan);
            Console.WriteLine("Universidades que rechazan: " + universidadesRechazan);
            Console.WriteLine("Universidades con empate: " + universidadesEmpate);

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;
        }
        }
    }
}