using System;

namespace tp_7_ejr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string entrada,curso,turno;
            int n, i;
            float num, num1, resul;
            n = 0;
            i = 0;
            num = 0f;
            num1 = 0f;
            resul = 0f;


            Console.Clear();
            Console.WriteLine("escriba el nombre del curso");
            curso = Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine ("escriba el turno");
            turno = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("escriba la cantidad de alumnos que son");
            entrada = Console.ReadLine();
            i = Convert.ToInt32(entrada);

            for (n = 1; n <= i; n = n + 1)
            {

                Console.Clear();
                Console.WriteLine("escriba la nota de los alumnos");
                entrada = Console.ReadLine();
                num = Convert.ToInt32(entrada);
                num1 = num1 + num;
            }
            Console.Clear();
            resul = num1 / i;
            Console.WriteLine("el cuso se llama {0}, el turno es {1} y el promedio de las notas de los alumnos es {2}",curso,turno, resul);
        }

        }
    }

