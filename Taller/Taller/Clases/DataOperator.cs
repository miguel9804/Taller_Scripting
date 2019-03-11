using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Clases
{
    abstract class DataOperator:DataGenerator
       
    {
        private int[] arrayInt;
        private float[] arrayFloat;
        private List<int> listaInt;
        private List<float> listaFloat;
        private Queue<int> colaInt;
        private Queue<float> colaFloat;
        private Stack<int> pilaInt;
        private Stack<float> pilaFloat;
        private Dictionary<string, int> dictInt;
        private Dictionary<string, float> dictFloat;

        protected DataOperator()
        {
            ArrayInt = PopulateArray(10, 30, true);
            ArrayFloat = PopulateArray(10, 30.5f, true);
            ListaInt = PopulateList(10, 50, true);
            ListaFloat = PopulateList(10, 50.40f, true);
            ColaInt = PopulateQueue(10, 20, true);
            ColaFloat = PopulateQueue(10, 20.134f, true);
            PilaInt = PopulateStack(10, 10, true);
            PilaFloat = PopulateStack(10, 10.698f, true);
            //DictInt = PopulateDict(10, 25, true);
            //DictFloat = PopulateDict(10, 25.98f, true);
        }

        public int[] ArrayInt { get => arrayInt; set => arrayInt = value; }
        public float[] ArrayFloat { get => arrayFloat; set => arrayFloat = value; }
        public List<int> ListaInt { get => listaInt; set => listaInt = value; }
        public List<float> ListaFloat { get => listaFloat; set => listaFloat = value; }
        public Queue<int> ColaInt { get => colaInt; set => colaInt = value; }
        public Queue<float> ColaFloat { get => colaFloat; set => colaFloat = value; }
        public Stack<int> PilaInt { get => pilaInt; set => pilaInt = value; }
        public Stack<float> PilaFloat { get => pilaFloat; set => pilaFloat = value; }

        public Dictionary<string, int> DictInt { get => dictInt; set => dictInt = value; }
        public Dictionary<string, float> DictFloat { get => dictFloat; set => dictFloat = value; }
        









        



    }
}
