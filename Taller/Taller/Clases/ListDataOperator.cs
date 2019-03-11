using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Clases
{
    class ListDataOperator:DataOperator
    {
        //Enteros
        public List<int> SortAscendingLisIn(out bool sucess)
        {
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar el conjunto de la lista de enteros en forma ascendente?");
            temp = Console.ReadLine();
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("El array ordenado:");
                    ListaInt.Sort();
                    for (int i = 0; i < ListaInt.Count; i++)
                    {
                        Console.WriteLine(ListaInt[i]);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                Console.WriteLine("La lista sin ordenar:");
                for (int i = 0; i < ListaInt.Count; i++)
                {
                    Console.WriteLine(ListaInt[i]);
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ListaInt;
        }
        public List<int> SortDescendingLisIn(out bool sucess)
        {
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar los numeros de la lista de enteros en forma descendente?");
            temp = Console.ReadLine();
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La lista descendete:");
                    ListaInt.Sort();
                    for (int i = ListaInt.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(ListaInt[i]);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                for (int i = 0; i < ListaInt.Count; i++)
                {
                    Console.WriteLine(ListaInt[i]);
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ListaInt;

        }
        public List<int> ShuffleLisIn(out bool sucess)
        {
            string temp;
            sucess = false;
            int n;
            int desordenar;
            Random rnd = new Random();
            Console.WriteLine("Quieres ordenar aleatoriamente los numeros de la lista de enteros?");
            temp = Console.ReadLine();

            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La lista aleatoria:");

                    for (int i = ListaInt.Count - 1; i >= 0; i--)
                    {
                       
                        n = rnd.Next(0, i);
                        ListaInt[i] = ListaInt[n];
                        desordenar = ListaInt[i];
                        ListaInt[n] = desordenar;
                        Console.WriteLine(desordenar);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La lista sin ordenar:");
                    for (int i = 0; i < ListaInt.Count; i++)
                    {
                        Console.WriteLine(ListaInt[i]);
                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ListaInt;
        }
        public List<int> RemoveOddsLisIn(out bool sucess)
        {
            string temp;
            sucess = false;
            Console.WriteLine("Quieres remover los numeros impares de la lista de enteros?");
            temp = Console.ReadLine();
            int remover;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    
                    
                    Console.WriteLine("Se removio:");
                    Console.WriteLine();
                    
                    for (int i = 0; i < ListaInt.Count; i++)
                    {
                        remover = ListaInt[i];
                        
                        if((remover%2)!=0)
                        {
                            Console.WriteLine(ListaInt[i]);
                            ListaInt.Remove(remover);
                            
                        }
                       
                    }
                    Console.WriteLine();
                    Console.WriteLine("La lista queda");
                    for(int i=0; i<ListaInt.Count;i++)
                    {
                        Console.WriteLine(ListaInt[i]);
                    }
                   
                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La lista sin ordenar:");
                    for (int i = 0; i < ListaInt.Count; i++)
                    {
                        Console.WriteLine(ListaInt[i]);

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ListaInt;
        }
        public List<int> RemoveEvenLisIn(out bool sucess)
        {
            string temp;
            sucess = false;
            List<int> prueba = new List<int>();
            Console.WriteLine("Quieres remover los numeros pares de la lista de enteros?");
            temp = Console.ReadLine();
            int remover;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {

                   
                    Console.WriteLine("Se removio:");
                    Console.WriteLine();

                    for (int i = 0; i < ListaInt.Count; i++)
                    {
                        remover = ListaInt[i];

                        if ((ListaInt[i] % 2) == 0)
                        {
                            Console.WriteLine(ListaInt[i]);
                            ListaInt.Remove(remover);

                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("La lista queda");
                    for (int i = 0; i < ListaInt.Count; i++)
                    {
                        Console.WriteLine(ListaInt[i]);
                    }

                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La lista sin ordenar:");
                    for (int i = 0; i < ListaInt.Count; i++)
                    {
                        Console.WriteLine(ListaInt[i]);

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ListaInt;
        }
        //Flotantes
        public List<float> SortAscendingLisFl(out bool sucess)
        {
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar el conjunto de la lista de flotantes en forma ascendente?");
            temp = Console.ReadLine();
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La lista ordenada:");
                    ListaFloat.Sort();
                    for (int i = 0; i < ListaFloat.Count; i++)
                    {
                        Console.WriteLine(ListaFloat[i]);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                Console.WriteLine("La lista sin ordenar:");
                for (int i = 0; i < ListaFloat.Count; i++)
                {
                    Console.WriteLine(ListaFloat[i]);
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ListaFloat;
        }
        public List<float> SortDescendingLisFl(out bool sucess)
        {
            string temp;
            sucess = false;
            Console.WriteLine("Quieres ordenar los numeros de la lista de enteros en forma descendente?");
            temp = Console.ReadLine();
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La lista descendete:");
                    ListaFloat.Sort();
                    for (int i = ListaFloat.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(ListaFloat[i]);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                for (int i = 0; i < ListaFloat.Count; i++)
                {
                    Console.WriteLine(ListaFloat[i]);
                }
            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ListaFloat;

        }
        public List<float> ShuffleLisFl(out bool sucess)
        {
            string temp;
            sucess = false;
            int n;
            float desordenar;
            Random rnd = new Random();
            Console.WriteLine("Quieres ordenar aleatoriamente los numeros de la lista de flotantes?");
            temp = Console.ReadLine();

            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La lista aleatoria:");

                    for (int i = ListaFloat.Count - 1; i >= 0; i--)
                    {

                        n = rnd.Next(0, i);
                        ListaFloat[i] = ListaFloat[n];
                        desordenar = ListaFloat[i];
                        ListaFloat[n] = desordenar;
                        Console.WriteLine(desordenar);
                    }
                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La lista sin ordenar:");
                    for (int i = 0; i < ListaFloat.Count; i++)
                    {
                        Console.WriteLine(ListaFloat[i]);
                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ListaFloat;
        }
        public List<float> RemoveOddsLisFl(out bool sucess)
        {
            string temp;
            sucess = false;
            Console.WriteLine("Quieres remover los numeros impares de la lista de flotantes?");
            temp = Console.ReadLine();
            
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {

                   
                    
                   

                    for (int i = 0; i < ListaFloat.Count; i++)
                    {
                        

                        if (ListaFloat[i]!= 0.0f)
                        {
                            ListaFloat.Remove(ListaFloat[i]);
                            Console.WriteLine("Se remueve el impar:" +ListaFloat[i]);
                            

                        }
                        else
                        {
                            Console.WriteLine("No hay impar");
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("La lista queda");
                    for (int i = 0; i < ListaFloat.Count; i++)
                    {
                        Console.WriteLine(ListaFloat[i]);
                    }

                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La lista sin ordenar:");
                    for (int i = 0; i < ListaFloat.Count; i++)
                    {
                        Console.WriteLine(ListaFloat[i]);

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ListaFloat;
        }
        public List<float> RemoveEvenLisFl(out bool sucess)
        {
            string temp;
            sucess = false;
            List<int> prueba = new List<int>();
            Console.WriteLine("Quieres remover los numeros pares de la lista de flotantes?");
            temp = Console.ReadLine();
            float remover;
            if (temp == "Si" || temp == "si")
            {
                sucess = true;
                if (sucess == true)
                {


                    Console.WriteLine("Se removio:");
                    Console.WriteLine();

                    for (int i = 0; i < ListaFloat.Count; i++)
                    {
                        remover = ListaFloat[i];

                        if (ListaInt[i]  == 0)
                        {
                            Console.WriteLine("Se remueve el par");
                            ListaFloat.Remove(ListaFloat[i]);

                        }
                        else
                        {
                            Console.WriteLine("No hay par");
                            
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("La lista queda");
                    for (int i = 0; i < ListaFloat.Count; i++)
                    {
                        Console.WriteLine(ListaFloat[i]);
                    }


                }
            }
            else if (temp == "No" || temp == "no")
            {
                sucess = true;
                if (sucess == true)
                {
                    Console.WriteLine("La lista sin ordenar:");
                    for (int i = 0; i < ListaFloat.Count; i++)
                    {
                        Console.WriteLine(ListaFloat[i]);

                    }
                }

            }
            else
            {
                Console.WriteLine("Tenias que escribir si o no");
            }

            return ListaFloat;
        }



    }
}
