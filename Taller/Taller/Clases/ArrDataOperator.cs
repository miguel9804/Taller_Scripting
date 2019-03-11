using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Clases
{
    class ArrDataOperator : DataOperator
    {

        //Enteros
        public int[] SortAscendingArIn(out bool sucess)
        {
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar el conjunto de array de enteros en forma ascendente?");
            temp = Console.ReadLine();
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("El array ordenado:");
                    Array.Sort(ArrayInt);
                    for (int i = 0; i < ArrayInt.Length; i++)
                    {
                        Console.WriteLine(ArrayInt[i]);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                Console.WriteLine("El array sin ordenar:");
                for (int i = 0; i < ArrayInt.Length; i++)
                {
                    Console.WriteLine(ArrayInt[i]);
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ArrayInt;



        }
        public int[] SortDescendingArIn(out bool sucess)
        {
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar el conjunto de array de enteros en forma descendente?");
            temp = Console.ReadLine();
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("El array descendete:");
                    Array.Sort(ArrayInt);
                    for (int i = ArrayInt.Length - 1; i >= 0; i--)
                    {
                        Console.WriteLine(ArrayInt[i]);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                for (int i = 0; i < ArrayInt.Length; i++)
                {
                    Console.WriteLine(ArrayInt[i]);
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ArrayInt;

        }
        public int[] ShuffleArIn(out bool sucess)
        {
            string temp;
            sucess = false;
            int n;
            int desordenar;
            Random rnd = new Random();
            Console.WriteLine("Quieres ordenar aleatoriamente el conjunto de array de enteros?");
            temp = Console.ReadLine();

            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("El array aleatorio:");

                    for (int i = ArrayInt.Length - 1; i >= 0; i--)
                    {
                        n = rnd.Next(0, i);
                        ArrayInt[i] = ArrayInt[n];
                        desordenar = ArrayInt[i];
                        ArrayInt[n] = desordenar;
                        Console.WriteLine(desordenar);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("El array sin ordenar:");
                    for (int i = 0; i < ArrayInt.Length; i++)
                    {
                        Console.WriteLine(ArrayInt[i]);
                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ArrayInt;
        }
        public int[] RemoveOddsArIn(out bool sucess)
        {
            string temp;
            sucess = false;
            Console.WriteLine("Quieres remover los numeros impares del array de enteros?");
            temp = Console.ReadLine();

            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("El array removiendo los nuermos impares");

                    for (int i = 0; i < ArrayInt.Length; i++)
                    {
                        if ((ArrayInt[i] % 2) == 0)
                        {
                            Console.WriteLine(ArrayInt[i]);
                        }
                        
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("El array sin ordenar:");
                    for (int i = 0; i < ArrayInt.Length; i++)
                    {
                        Console.WriteLine(ArrayInt[i]);

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ArrayInt;
        }
        public int[] RemoveEvenArIn(out bool sucess)
        {
            string temp;
            sucess = false;
            Console.WriteLine("Quieres remover los numeros pares del array de enteros?");
            temp = Console.ReadLine();

            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("El array removiendo los nuermos pares");

                    for (int i = 0; i < ArrayInt.Length; i++)
                    {
                        if ((ArrayInt[i] % 2) != 0)
                        {
                            Console.WriteLine(ArrayInt[i]);
                        }

                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("El array sin ordenar:");
                    for (int i = 0; i < ArrayInt.Length; i++)
                    {
                        Console.WriteLine(ArrayInt[i]);

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ArrayInt;
        }
        
        //Flotantes
        public float[] SortAscendingArFl(out bool sucess)
         {
        string temp;
        sucess = false;
        Console.WriteLine("Quieres ordenar el conjunto de array de flotantes en forma ascendente?");
        temp = Console.ReadLine();
        if (temp == "Si" || temp == "si")
        {
            sucess = true;
            if (sucess == true)
            {
                Console.WriteLine("El array ordenado:");
                Array.Sort(ArrayFloat);
                for (int i = 0; i < ArrayFloat.Length; i++)
                {
                    Console.WriteLine(ArrayFloat[i]);
                }
            }
        }
        else if (temp == "No" || temp == "no")
        {
            Console.WriteLine("El array sin ordenar:");
            for (int i = 0; i < ArrayFloat.Length; i++)
            {
                Console.WriteLine(ArrayFloat[i]);
            }
        }
        else
        {
            Console.WriteLine("Tenias que escribir si o no");
        }

        return ArrayFloat;

    }
         public float[] SortDescendingArFl(out bool sucess)
          {
        string temp;
        sucess = false;
        Console.WriteLine("Quieres ordenar el conjunto de array de flotantes en forma descendente?");
        temp = Console.ReadLine();
        if (temp == "Si" || temp == "si")
        {
            sucess = true;
            if (sucess == true)
            {
                Console.WriteLine("El array ordenado:");
                Array.Sort(ArrayFloat);
                for (int i = ArrayFloat.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(ArrayFloat[i]);
                }
            }
        }
        else if (temp == "No" || temp == "no")
        {
            Console.WriteLine("El array sin ordenar:");
            Console.WriteLine("El array sin ordenar:");
            for (int i = 0; i < ArrayFloat.Length; i++)
            {
                Console.WriteLine(ArrayFloat[i]);
            }
        }
        else
        {
            Console.WriteLine("Tenias que escribir si o no");
        }

        return ArrayFloat;
    }
         public float[] ShuffleArFl(out bool sucess)
            {
        string temp;
        sucess = false;
        int n;
        float desordenar;
        Random rnd = new Random();
        Console.WriteLine("Quieres ordenar aleatoriamente el conjunto de array de flotantes?");
        temp = Console.ReadLine();
        if (temp == "Si" || temp == "si")
        {
            sucess = true;
            if (sucess == true)
            {
                Console.WriteLine("El array aleatorio:");
                
                for (int i = ArrayFloat.Length - 1; i >= 0; i--)
                {
                    n = rnd.Next(0, i);
                    ArrayFloat[i] = ArrayFloat[n];
                    desordenar = ArrayFloat[i];
                    ArrayFloat[n] = desordenar;
                    Console.WriteLine(desordenar);
                }
            }
        }
        else if (temp == "No" || temp == "no")
        {
            Console.WriteLine("El array sin ordenar:");
            for (int i = 0; i < ArrayFloat.Length; i++)
            {
                Console.WriteLine(ArrayFloat[i]);
            }
        }


        return ArrayFloat;

    }
         public float[] RemoveOddsArFl(out bool sucess)
         {
            string temp;
            sucess = false;
            Console.WriteLine("Quieres remover los numeros impares del arrat de flotantes?");
            temp = Console.ReadLine();
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("El array removiendo sus impares:");
                    
                    for (int i = 0; i < ArrayFloat.Length; i++)
                    {
                        if((ArrayFloat[i]%2)==0)
                        {
                            Console.WriteLine(ArrayFloat[i]);
                        }
                        else
                        {
                            Console.WriteLine("Se removio el impar");
                        }
                        
                       
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                Console.WriteLine("El array sin ordenar:");
                for (int i = 0; i < ArrayFloat.Length; i++)
                {
                    Console.WriteLine(ArrayFloat[i]);
                }
            }


            return ArrayFloat;
         }
        public float[] RemoveEvenArFl(out bool sucess)
        {
            string temp;
            sucess = false;
            Console.WriteLine("Quieres remover los numeros pares del array de flotantes?");
            temp = Console.ReadLine();
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("El array removiendo sus pares:");

                    for (int i = 0; i < ArrayFloat.Length; i++)
                    {
                        if ((ArrayFloat[i] % 2) != 0)
                        {
                            Console.WriteLine(ArrayFloat[i]);
                        }
                        else
                        {
                            Console.WriteLine("Removi par");
                        }

                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                Console.WriteLine("El array sin ordenar:");
                for (int i = 0; i < ArrayFloat.Length; i++)
                {
                    Console.WriteLine(ArrayFloat[i]);
                }
            }


            return ArrayFloat;
        }

        //public ItemSlot[] SortDescending(out bool sucess)

        //public ItemSlot[] SortAscendingArIt(out bool sucess)
        // public ItemSlot{[] ShuffleArIt(out bool sucess)


    }
}
