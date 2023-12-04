using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaPushUp.Retos;
public class RetoCuatro{
    public void reto4(){
    {
        Console.Write("Ingrese la cantidad de universidades que participan en el proceso: ");
        int cantidadUniversidades = int.Parse(Console.ReadLine());

        List<Universidad> universidades = new List<Universidad>();

        for (int i = 0; i < cantidadUniversidades; i++){
            Console.Write($"Ingrese el nombre de la universidad {i + 1}: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese los votos de los alumnos (A: aceptar, R: rechazar, N: nulo, B: blanco). Terminar con X:");

            List<string> votos = new List<string>();
            string voto;
            do
            {
                Console.Write("Voto: ");
                voto = Console.ReadLine().ToUpper();

                if (voto == "A" || voto == "R" || voto == "N" || voto == "B")
                {
                    votos.Add(voto);
                }
                else if (voto != "X")
                {
                    Console.WriteLine("Voto inválido. Intente nuevamente.");
                }
            } while (voto != "X");

            universidades.Add(new Universidad(nombre, votos));
        }

        MostrarResultados(universidades);
    }

    static void MostrarResultados(List<Universidad> universidades){
        int aceptan = universidades.Count(u => u.TotalVotos("A") > u.TotalVotos("R"));
        int rechazan = universidades.Count(u => u.TotalVotos("R") > u.TotalVotos("A"));
        int empate = universidades.Count(u => u.TotalVotos("A") == u.TotalVotos("R"));

        Console.WriteLine($"Resultados de la votación:");
        Console.WriteLine($"Universidades que aceptan: {aceptan}");
        Console.WriteLine($"Universidades que rechazan: {rechazan}");
        Console.WriteLine($"Universidades con empate: {empate}");
    }
    }

    class Universidad
    {
        public string Nombre { get; }
        public List<string> Votos { get; }
        public Universidad(string nombre, List<string> votos)
        {
            Nombre = nombre;
            Votos = votos;
        }
        public int TotalVotos(string opcion)
        {
            return Votos.Count(v => v == opcion);
        }
    }
}





