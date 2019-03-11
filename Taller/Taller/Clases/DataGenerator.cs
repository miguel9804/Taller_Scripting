using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Clases
{
    class DataGenerator
    {
        public int[] PopulateArray(int size, int maxNumber, bool randomData)
        {
            int[] array = new int[size];
            Random r = new Random();
            if (randomData == true)
            {
                for (int i = 0; i < array.Length; i++)
                {

                    array[i] = r.Next(0, maxNumber);

                }

            }

            else
            {
                int numero = 12;
                for (int i = 0; i < array.Length; i++)
                {

                    array[i] = numero;
                    numero += 2;
                }
            }
            return array;

        }
        public float[] PopulateArray(int size, float maxNumber, bool randomData)
        {
            float[] array = new float[size];
            Random r = new Random();
            float n;
            int n2;

            if (randomData == true)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    n = (float)r.NextDouble();
                    n2 = r.Next(0, (int)maxNumber);
                    array[i] = n * n2;
                }

            }
            else
            {
                float m = 12.463414432f;
                for (int i = 0; i < array.Length; i++)
                {

                    array[i] = m;
                    m *= 0.555f;
                }
            }
            return array;

        }
        //public ItemSlot[] PopulateArray(int size)
        public List<int> PopulateList(int size, int maxNumber, bool randomData)
        {
            List<int> lista = new List<int>();
            Random r = new Random();
            if (randomData == true)
            {
                for (int i = 0; i < size; i++)
                {
                    lista.Add(r.Next(0, maxNumber));

                }
            }
            else
            {
                int numero = 20;
                for (int i = 0; i < size; i++)
                {
                    lista.Add(numero);
                    numero *= 2;
                }
            }
            return lista;
        }
        public  List<float> PopulateList(int size, float maxNumber, bool randomData)
        {
            List<float> lista = new List<float>();
            Random r = new Random();
            float n;
            int n2;
            if (randomData == true)
            {
                for (int i = 0; i < size; i++)
                {
                    n = (float)r.NextDouble();
                    n2 = r.Next(0, (int)maxNumber);
                    lista.Add(n * n2);

                }
            }
            else
            {
                float numero = 20.695f;
                for (int i = 0; i < size; i++)
                {
                    lista.Add(numero);
                    numero *= 1.4333f;
                }
            }
            return lista;
        }
        //public List<ItemSlot> PopulateList(int size)
        public  Queue<int> PopulateQueue(int size, int maxNumber, bool randomData)
        {
            Queue<int> cola = new Queue<int>();
            Random r = new Random();
            
            if(randomData==true)
            {
                for(int i=0; i<size;i++)
                {
                    
                    cola.Enqueue(r.Next(0, maxNumber));
                }
            }
            else
            {
                int numero = 25;
                for(int i=0;i<size;i++)
                {
                    cola.Enqueue(numero);
                    numero -= 5;
                }
            }

            return cola;
        }
        public  Queue<float> PopulateQueue(int size, float maxNumber, bool randomData)
        {
            Queue<float> cola = new Queue<float>();
            Random r = new Random();
            float n;
            int n2;
            if (randomData == true)
            {
                for (int i = 0; i < size; i++)
                {
                    n = (float)r.NextDouble();
                    n2 = r.Next(0, (int)maxNumber);
                    cola.Enqueue(n*n2);
                }
            }
            else
            {
                float numero = 25.13f;
                for (int i = 0; i < size; i++)
                {
                    cola.Enqueue(numero);
                    numero /= 5.56f;
                }
            }

            return cola;
        }
        //public Queue<ItemSlot> PopulateQueue(int size)
        public  Stack<int> PopulateStack(int size, int maxNumber,bool randomData)
        {
            Stack<int> pila = new Stack<int>();
            Random r = new Random();
            if(randomData==true)
            { 
                for(int i=0;i<size;i++)
                {
                    pila.Push(r.Next(0, maxNumber));
                }

           
            }
            else
            {
                int numero = 1;
                for(int i=0; i<size;i++)
                {
                    pila.Push(numero);
                    numero++;
                }
            }
            return pila;
        }
        public  Stack<float> PopulateStack(int size, float maxNumber, bool randomData)
        {
            Stack<float> pila = new Stack<float>();
            Random r = new Random();
            float n;
            int n2;
            if (randomData == true)
            {
                for (int i = 0; i < size; i++)
                {
                    n = (float)r.NextDouble();
                    n2 = r.Next(0, (int)maxNumber);
                    pila.Push(n*n2);
                }


            }
            else
            {
                float numero = 3.1416f;
                for (int i = 0; i < size; i++)
                {
                    pila.Push(numero);
                    numero/=0.9f;
                }
            }
            return pila;
        }
        //public Stack<ItemSlot> PopulateStack(int size)
      /* public  Dictionary<string,int> PopulateDict(int size, int maxNumber, bool randomData)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            Random r = new Random();
            Console.WriteLine("Escribe " + size + " nombres:");
            string temp;
            if(randomData==true)
            {
                for (int i = 0; i < size; i++)
                {
                    temp = Console.ReadLine();
                    if (!diccionario.Keys.Contains(temp))
                    {
                        diccionario.Add(temp, r.Next(0, maxNumber));

                    }
                    else
                    {
                        Console.WriteLine("Repitio un nombre");
                        break;
                    }

                }
            }
            else
            {
                int numero = 50;
                for(int i=0;i<size; i++)
                {
                    temp = Console.ReadLine();
                    if (!diccionario.Keys.Contains(temp))
                    {
                        diccionario.Add(temp, numero);
                        numero += 10;

                    }
                    else
                    {
                        Console.WriteLine("Repitio un nombre");
                        break;
                    }
                    
                }
            }
            
            return diccionario;   
        }
        public  Dictionary<string,float> PopulateDict(int size, float maxNumber, bool randomData)
        {
            Dictionary<string, float> diccionario = new Dictionary<string, float>();
            Random r = new Random();
            Console.WriteLine("Escribe " + size + " nombres:");
            string temp;
            float n;
            int n2;
            if (randomData == true)
            {
                for (int i = 0; i < size; i++)
                {
                    temp = Console.ReadLine();
                    if (!diccionario.Keys.Contains(temp))
                    {

                        n = (float)r.NextDouble();
                        n2 = r.Next(0, (int)maxNumber);
                        diccionario.Add(temp, n * n2);
                    }
                    else
                    {
                        Console.WriteLine("Repitio un nombre");
                        break;
                    }

                }
            }
            else
            {
                float numero = 30.50f;
                for (int i = 0; i < size; i++)
                {
                    temp = Console.ReadLine();
                    if (!diccionario.Keys.Contains(temp))
                    {
                        diccionario.Add(temp, numero);
                        numero /= 0.5555f;

                    }
                    else
                    {
                        Console.WriteLine("Repitio un nombre");
                        break;
                    }

                }
            }

            return diccionario;
        }*/
        //public Dictionary<string,ItemSlot> PopulateDict(int size)
    }
}
