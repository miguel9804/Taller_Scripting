using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Clases
{
    class StackDataOperator:DataOperator
    {
        //Enteros
        public Stack<int> SortAscendingStaIn(out bool sucess)
        {
            List<int> orden = new List<int>();
            int dato;
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar el conjunto de la pila de enteros en forma ascendente?");
            temp = Console.ReadLine();
            int contador;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = PilaInt.Count;

                    for (int i = 0; i < contador; i++)
                    {
                        dato = PilaInt.Pop();

                        orden.Add(dato);
                    }

                    orden.Sort();
                    contador = orden.Count;
                    Console.WriteLine("La pila ordenada:");

                    for (int i = 0; i < contador; i++)
                    {

                        PilaInt.Push(orden[i]);
                        Console.WriteLine(PilaInt.Pop());
                    }

                    for (int i = 0; i < orden.Count; i++)
                    {
                        orden.Remove(i);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                contador = PilaInt.Count;
                Console.WriteLine("La pila sin ordenar:");
                for (int i = 0; i <contador; i++)
                {
                    Console.WriteLine(PilaInt.Pop());
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return PilaInt;
        }
        public Stack<int> SortDescendingStaIn(out bool sucess)
        {
            List<int> orden = new List<int>();
            int dato;
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar el conjunto de la pila de enteros en forma descendente?");
            temp = Console.ReadLine();
            int contador;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = PilaInt.Count;

                    for (int i = 0; i < contador; i++)
                    {
                        dato = PilaInt.Pop();

                        orden.Add(dato);
                    }

                    orden.Sort();
                    contador = orden.Count;
                    Console.WriteLine("La pila ordenada:");

                    for (int i = contador-1; i >=0; i--)
                    {

                        PilaInt.Push(orden[i]);
                        Console.WriteLine(PilaInt.Pop());
                    }

                    for (int i = 0; i < orden.Count; i++)
                    {
                        orden.Remove(i);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                contador = PilaInt.Count;
                Console.WriteLine("La pila sin ordenar:");
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine(PilaInt.Pop());
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return PilaInt;
        }
        public Stack<int> RemoveOddsStaIn(out bool sucess)
        {
            string temp;
            sucess = false;
            int contador;
            Console.WriteLine("Quieres remover los numeros impares de la pila de enteros?");
            temp = Console.ReadLine();
            int dato;
            
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = PilaInt.Count;

                    Console.WriteLine("Los numeros que se agregan y se eliminan son: ");

                    for (int i = 0; i < contador; i++)
                    {
                        dato = PilaInt.Pop();
                        Console.WriteLine(dato);
                        

                        if ((dato % 2) != 0)
                        {
                            Console.WriteLine("Este se elimina: "+dato);

                        }
                        else
                        {
                            PilaInt.Push(dato);
                            Console.WriteLine("Este se agrega: " + dato);
                        }

                    }
                    Console.WriteLine();
                    contador = PilaInt.Count;
                    Console.WriteLine("La pila tiene "+contador+" numeros");
                    /* for(int i = 0; i < contador;i++)
                    {
                       
                        Console.WriteLine(PilaInt.Pop());
                   
                    }*/

                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = PilaInt.Count;
                    Console.WriteLine("La pila sin ordenar:");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine(PilaInt.Pop());

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return PilaInt;
        }
        public Stack<int> RemoveEvenStaIn(out bool sucess)
        {
            string temp;
            sucess = false;
            int contador;
            Console.WriteLine("Quieres remover los numeros pares de la pila de enteros?");
            temp = Console.ReadLine();
            int dato;

            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = PilaInt.Count;

                    Console.WriteLine("Los numeros que se agregan y se elimnan son:");

                    for (int i = 0; i < contador; i++)
                    {
                        dato = PilaInt.Pop();
                        Console.WriteLine(dato);


                        if ((dato % 2) == 0)
                        {
                            Console.WriteLine("Este se elimina: " + dato);

                        }
                        else
                        {
                            PilaInt.Push(dato);
                            Console.WriteLine("Este se agrega: " + dato);
                        }

                    }
                    Console.WriteLine();
                    contador = PilaInt.Count;
                    Console.WriteLine("La pila tiene " + contador + " numeros");
                    /* for(int i = 0; i < contador;i++)
                    {
                       
                        Console.WriteLine(PilaInt.Pop());
                   
                    }*/

                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = PilaInt.Count;
                    Console.WriteLine("La pila sin ordenar:");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine(PilaInt.Pop());

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return PilaInt;
        }
        //Flotantes
        public Stack<float> SortAscendingStaFl(out bool sucess)
        {
            List<float> orden = new List<float>();
            float dato;
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar el conjunto de la pila de enteros en forma ascendente?");
            temp = Console.ReadLine();
            int contador;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = PilaFloat.Count;

                    for (int i = 0; i < contador; i++)
                    {
                        dato = PilaFloat.Pop();

                        orden.Add(dato);
                    }

                    orden.Sort();
                    contador = orden.Count;
                    Console.WriteLine("La pila ordenada:");

                    for (int i = 0; i < contador; i++)
                    {

                        PilaFloat.Push(orden[i]);
                        Console.WriteLine(PilaFloat.Pop());
                    }

                    for (int i = 0; i < orden.Count; i++)
                    {
                        orden.Remove(i);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                contador = PilaFloat.Count;
                Console.WriteLine("La pila sin ordenar:");
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine(PilaFloat.Pop());
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return PilaFloat;
        }
        public Stack<float> SortDescendingStaFl(out bool sucess)
        {
            List<float> orden = new List<float>();
            float dato;
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar el conjunto de la pila de enteros en forma descendente?");
            temp = Console.ReadLine();
            int contador;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = PilaFloat.Count;

                    for (int i = 0; i < contador; i++)
                    {
                        dato = PilaFloat.Pop();

                        orden.Add(dato);
                    }

                    orden.Sort();
                    contador = orden.Count;
                    Console.WriteLine("La pila ordenada:");

                    for (int i = contador - 1; i >= 0; i--)
                    {

                        PilaFloat.Push(orden[i]);
                        Console.WriteLine(PilaFloat.Pop());
                    }

                    for (int i = 0; i < orden.Count; i++)
                    {
                        orden.Remove(i);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                contador = PilaFloat.Count;
                Console.WriteLine("La pila sin ordenar:");
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine(PilaFloat.Pop());
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return PilaFloat;
        }
        public Stack<float> RemoveOddsStaFl(out bool sucess)
        {
            string temp;
            sucess = false;
            int contador;
            Console.WriteLine("Quieres remover los numeros impares de la pila de enteros?");
            temp = Console.ReadLine();
            float dato;

            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = PilaFloat.Count;

                    Console.WriteLine("Los numeros que se agregan y se eliminan son: ");

                    for (int i = 0; i < contador; i++)
                    {
                        dato = PilaFloat.Pop();
                        Console.WriteLine(dato);


                        if ((dato % 2) != 0)
                        {
                            Console.WriteLine("Este se elimina: " + dato);

                        }
                        else
                        {
                            PilaFloat.Push(dato);
                            Console.WriteLine("Este se agrega: " + dato);
                        }

                    }
                    Console.WriteLine();
                    contador = PilaFloat.Count;
                    Console.WriteLine("La pila tiene " + contador + " numeros");
                    /* for(int i = 0; i < contador;i++)
                    {
                       
                        Console.WriteLine(PilaInt.Pop());
                   
                    }*/

                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = PilaFloat.Count;
                    Console.WriteLine("La pila sin ordenar:");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine(PilaFloat.Pop());

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return PilaFloat;
        }
        public Stack<float> RemoveEvenStaFl(out bool sucess)
        {
            string temp;
            sucess = false;
            int contador;
            Console.WriteLine("Quieres remover los numeros pares de la pila de enteros?");
            temp = Console.ReadLine();
           float dato;

            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = PilaFloat.Count;

                    Console.WriteLine("Los numeros que se agregan y se elimnan son:");

                    for (int i = 0; i < contador; i++)
                    {
                        dato = PilaFloat.Pop();
                        Console.WriteLine(dato);


                        if ((dato % 2) == 0)
                        {
                            Console.WriteLine("Este se elimina: " + dato);

                        }
                        else
                        {
                            PilaFloat.Push(dato);
                            Console.WriteLine("Este se agrega: " + dato);
                        }

                    }
                    Console.WriteLine();
                    contador = PilaFloat.Count;
                    Console.WriteLine("La pila tiene " + contador + " numeros");
                    /* for(int i = 0; i < contador;i++)
                    {
                       
                        Console.WriteLine(PilaInt.Pop());
                   
                    }*/

                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    contador = PilaFloat.Count;
                    Console.WriteLine("La pila sin ordenar:");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine(PilaFloat.Pop());

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return PilaFloat;
        }



    }
    

}
