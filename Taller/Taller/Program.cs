using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller.Clases;

namespace Taller
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            bool accion;
            ArrDataOperator arr = new ArrDataOperator();
            ListDataOperator lis = new ListDataOperator();
            QueueDataOperator que = new QueueDataOperator();
            StackDataOperator sta = new StackDataOperator();
            Console.WriteLine("Responde con true o false: ");
           //Arrys
            Console.WriteLine(" - Arrays, deseas verlos?");
            temp = Console.ReadLine();
            if (bool.TryParse(temp, out accion))
              {
                
               if (accion == true)
               {
                    arr.SortAscendingArIn(out accion);
                    Console.WriteLine();
                    arr.SortAscendingArFl(out accion);
                    Console.WriteLine();
                    arr.SortDescendingArIn(out accion);
                    Console.WriteLine();
                    arr.SortDescendingArFl(out accion);
                    Console.WriteLine();
                    arr.ShuffleArIn(out accion);
                    Console.WriteLine();
                    arr.ShuffleArFl(out accion);
                    Console.WriteLine();
                    arr.RemoveOddsArIn(out accion);
                    Console.WriteLine();
                    arr.RemoveOddsArFl(out accion);
                    Console.WriteLine();
                    arr.RemoveEvenArIn(out accion);
                    Console.WriteLine();
                    arr.RemoveEvenArFl(out accion);
                    Console.WriteLine();


                }
                    else
                    {
                        Console.WriteLine("Sigamos con el siguiente");

                    }
                

              }
              else
              {
                Console.WriteLine("Era true o false");
                Console.WriteLine("Sigamos con el siguiente");
              }
            //Listas
            Console.WriteLine(" - Listas, deseas verlas?");
            temp = Console.ReadLine();
            if (bool.TryParse(temp, out accion))
            {

                if (accion == true)
                {
                    lis.SortAscendingLisIn(out accion);
                    Console.WriteLine();
                    lis.SortAscendingLisFl(out accion);
                    Console.WriteLine();
                    lis.SortDescendingLisIn(out accion);
                    Console.WriteLine();
                    lis.SortDescendingLisFl(out accion);
                    Console.WriteLine();
                    lis.ShuffleLisIn(out accion);
                    Console.WriteLine();
                    lis.ShuffleLisFl(out accion);
                    Console.WriteLine();
                    lis.RemoveOddsLisIn(out accion);
                    Console.WriteLine();
                    lis.RemoveOddsLisFl(out accion);
                    Console.WriteLine();
                    lis.RemoveEvenLisIn(out accion);
                    Console.WriteLine();
                    lis.RemoveEvenLisFl(out accion);
                    Console.WriteLine();


                }
                else
                {
                    Console.WriteLine("Sigamos con el siguiente");

                }


            }
            else
            {
                Console.WriteLine("Era true o false");
                Console.WriteLine("Sigamos con el siguiente");
            }
            //Colas
            Console.WriteLine(" - Colas, deseas verlas?");
            temp = Console.ReadLine();
            if (bool.TryParse(temp, out accion))
            {

                if (accion == true)
                {
                    que.SortAscendingQueIn(out accion);
                     Console.WriteLine();
                     que.SortAscendingQueFl(out accion);
                     Console.WriteLine();
                    que.SortDescendingQueIn(out accion);
                    Console.WriteLine();
                    que.SortDescendingQueFl(out accion);
                    Console.WriteLine();
                    que.RemoveOddsQueIn(out accion);
                    Console.WriteLine();
                    que.RemoveOddsQueFl(out accion);
                    Console.WriteLine();
                    que.RemoveEvenQueIn(out accion);
                    Console.WriteLine();
                    que.RemoveEvenQueFl(out accion);
                    Console.WriteLine();


                }
                else
                {
                    Console.WriteLine("Sigamos con el siguiente");

                }


            }
            else
            {
                Console.WriteLine("Era true o false");
                Console.WriteLine("Sigamos con el siguiente");
            }
            //Pilas
            Console.WriteLine(" - Pilas, deseas verlas?");
            temp = Console.ReadLine();
            if (bool.TryParse(temp, out accion))
            {

                if (accion == true)
                {
                    sta.SortAscendingStaIn(out accion);
                    Console.WriteLine();
                    sta.SortAscendingStaFl(out accion);
                    Console.WriteLine();
                    sta.SortDescendingStaIn(out accion);
                    Console.WriteLine();
                    sta.SortDescendingStaFl(out accion);
                    Console.WriteLine();
                    sta.RemoveOddsStaIn(out accion);
                    Console.WriteLine();
                    sta.RemoveOddsStaFl(out accion);
                    Console.WriteLine();
                    sta.RemoveEvenStaIn(out accion);
                    Console.WriteLine();
                    sta.RemoveEvenStaFl(out accion);
                    Console.WriteLine();


                }
                


            }
            else
            {
                Console.WriteLine("Era true o false");
                
            }
            Console.ReadKey();
            
            
        }

    }
}
