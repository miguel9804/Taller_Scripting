using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Clases
{
    class QueueDataOperator:DataOperator
    {
        //Enteros
        public Queue<int> SortAscendingQueIn(out bool sucess)
         {
            List<int> orden = new List<int>();
            int dato;
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar el conjunto de la cola de enteros en forma ascendente?");
            temp = Console.ReadLine();
            int contador;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = ColaInt.Count;
                    
                    for (int i = 0; i < contador; i++)
                    {
                        dato = ColaInt.Dequeue();

                        orden.Add(dato);
                    }

                    orden.Sort();
                    contador = orden.Count;
                    Console.WriteLine("La cola ordenada:");
                    
                    for (int i=0;i<orden.Count;i++)
                    {
                        
                        ColaInt.Enqueue(orden[i]);
                        Console.WriteLine(ColaInt.Dequeue());
                    }
                    
                    for(int i=0;i<orden.Count;i++)
                    {
                        orden.Remove(i);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                Console.WriteLine("La lista sin ordenar:");
                for (int i = 0; i < ColaInt.Count; i++)
                {
                    Console.WriteLine(ColaInt.Dequeue());
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ColaInt;
        }
        public Queue<int> SortDescendingQueIn(out bool sucess)
        
            {
            List<int> orden = new List<int>();
            int dato;
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar el conjunto de la cola de enteros en forma descendente?");
            temp = Console.ReadLine();
            int contador;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = ColaInt.Count;

                    for (int i = 0; i < contador; i++)
                    {
                        dato = ColaInt.Dequeue();
                        orden.Add(dato);
                    }

                    orden.Sort();
                    contador = orden.Count;
                    Console.WriteLine("La cola descendente:");

                    for (int i = orden.Count-1; i >= 0; i--)
                    {

                        ColaInt.Enqueue(orden[i]);
                        Console.WriteLine(ColaInt.Dequeue());
                    }

                    for (int i = 0; i < orden.Count; i++)
                    {
                        orden.Remove(i);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                Console.WriteLine("La lista sin ordenar:");
                for (int i = 0; i < ColaInt.Count; i++)
                {
                    Console.WriteLine(ColaInt.Dequeue());
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ColaInt;
        }
        public Queue<int> RemoveOddsQueIn(out bool sucess)
        {
            string temp;
            sucess = false;
            int contador;
            Console.WriteLine("Quieres remover los numeros impares de la cola de enteros?");
            temp = Console.ReadLine();
            int dato;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = ColaInt.Count;

                    Console.WriteLine("Se removio:");
               
                    for (int i = 0; i < contador; i++)
                    {
                        
                        dato = ColaInt.Dequeue();
                       

                        if ((dato % 2) != 0)
                        {
                            Console.WriteLine(dato);
                        }
                        else
                        {
                            ColaInt.Enqueue(dato);
                        }
                       

                    }
                    contador = ColaInt.Count;
                    Console.WriteLine();
                    Console.WriteLine("La cola queda");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine(ColaInt.Dequeue());
                    }

                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La cola sin ordenar:");
                    for (int i = 0; i < ColaFloat.Count; i++)
                    {
                        Console.WriteLine(ColaFloat.Dequeue());

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ColaInt;
        }
        public Queue<int> RemoveEvenQueIn(out bool sucess)
        {
            string temp;
            sucess = false;
            int contador;
            Console.WriteLine("Quieres remover los numeros pares de la cola de enteros?");
            temp = Console.ReadLine();
            int dato;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = ColaInt.Count;

                    Console.WriteLine("Se removio:");

                    for (int i = 0; i < contador; i++)
                    {

                        dato = ColaInt.Dequeue();


                        if ((dato % 2) == 0)
                        {
                            Console.WriteLine(dato);
                        }
                        else
                        {
                            ColaInt.Enqueue(dato);
                        }


                    }
                    contador = ColaInt.Count;
                    Console.WriteLine();
                    Console.WriteLine("La cola queda");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine(ColaInt.Dequeue());
                    }

                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La cola sin ordenar:");
                    for (int i = 0; i < ColaFloat.Count; i++)
                    {
                        Console.WriteLine(ColaFloat.Dequeue());

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ColaInt;
        }
        //Flotantes
        public Queue<float> SortAscendingQueFl(out bool sucess)
         {
            List<float> orden = new List<float>();
            float dato;
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar el conjunto de la cola de flotantes en forma ascendente?");
            temp = Console.ReadLine();
            int contador;
           
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = ColaFloat.Count;

                    for (int i = 0; i < contador; i++)
                    {
                        dato = ColaFloat.Dequeue();

                        orden.Add(dato);
                    }

                    orden.Sort();
                    contador = orden.Count;
                    Console.WriteLine("La cola ordenada:");

                    for (int i = 0; i < contador; i++)
                    {
                        
                        ColaFloat.Enqueue(orden[i]);
                        Console.WriteLine(ColaFloat.Dequeue());
                    }

                    for (int i = 0; i < contador; i++)
                    {
                        orden.Remove(i);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                Console.WriteLine("La lista sin ordenar:");
                for (int i = 0; i < ColaFloat.Count; i++)
                {
                    Console.WriteLine(ColaFloat.Dequeue());
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ColaFloat;
        }
        public Queue<float> SortDescendingQueFl(out bool sucess)
        {
            List<float> orden = new List<float>();
            float dato;
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar el conjunto de la cola de flotantes en forma ascendente?");
            temp = Console.ReadLine();
            int contador;

            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = ColaFloat.Count;

                    for (int i = 0; i < contador; i++)
                    {
                        dato = ColaFloat.Dequeue();

                        orden.Add(dato);
                    }

                    orden.Sort();
                    contador = orden.Count;
                    Console.WriteLine("La cola ordenada:");

                    for (int i = contador-1; i >=0 ; i--)
                    {

                        ColaFloat.Enqueue(orden[i]);
                        Console.WriteLine(ColaFloat.Dequeue());
                    }

                    for (int i = 0; i < contador; i++)
                    {
                        orden.Remove(i);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                Console.WriteLine("La lista sin ordenar:");
                for (int i = 0; i < ColaFloat.Count; i++)
                {
                    Console.WriteLine(ColaFloat.Dequeue());
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ColaFloat;
        }
        public Queue<float> RemoveOddsQueFl(out bool sucess)
         {
            string temp;
            sucess = false;
            int contador;
            Console.WriteLine("Quieres remover los numeros impares de la cola de flotantes?");
            temp = Console.ReadLine();
            float dato;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = ColaFloat.Count;

                    Console.WriteLine("Se removio:");

                    for (int i = 0; i < contador; i++)
                    {

                        dato = ColaFloat.Dequeue();


                        if ((dato % 2) != 0)
                        {
                            Console.WriteLine(dato);
                        }
                        else
                        {
                            ColaFloat.Enqueue(dato);
                        }


                    }
                    contador = ColaFloat.Count;
                    Console.WriteLine();
                    if(contador!=0)
                    {
                        Console.WriteLine("La cola queda:");
                        for (int i = 0; i < contador; i++)
                        {
                           Console.WriteLine(ColaFloat.Dequeue());
                            

                        }
                    }
                    else
                    {
                        Console.WriteLine("No tiene mas datos la cola");
                    }
                   

                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La cola sin ordenar:");
                    for (int i = 0; i < ColaFloat.Count; i++)
                    {
                        Console.WriteLine(ColaFloat.Dequeue());

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ColaFloat;
        }

        public Queue<float> RemoveEvenQueFl(out bool sucess)
        {
            string temp;
            sucess = false;
            int contador;
            Console.WriteLine("Quieres remover los numeros pares de la cola de flotantes?");
            temp = Console.ReadLine();
            float dato;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = ColaFloat.Count;

                    Console.WriteLine("Se removio:");

                    for (int i = 0; i < contador; i++)
                    {

                        dato = ColaFloat.Dequeue();


                        if ((dato % 2) == 0)
                        {
                            Console.WriteLine(dato);
                        }
                        else
                        {
                            ColaFloat.Enqueue(dato);
                        }


                    }
                    contador = ColaFloat.Count;
                    Console.WriteLine();
                    if (contador != 0)
                    {
                        Console.WriteLine("La cola queda:");
                        for (int i = 0; i < contador; i++)
                        {
                            Console.WriteLine(ColaFloat.Dequeue());


                        }
                    }
                    else
                    {
                        Console.WriteLine("No tiene mas datos la cola");
                    }


                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La cola sin ordenar:");
                    for (int i = 0; i < ColaFloat.Count; i++)
                    {
                        Console.WriteLine(ColaFloat.Dequeue());

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ColaFloat;
        }

    }

}
