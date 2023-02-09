using System.Numerics;

namespace graph2
{
    internal class Graph
    {
        private int size; // количество вершин в графе
        private Node[] adjList; // ссылка на список смежности вершин графа
        private bool[,] adjacency; // матрица смежности графа
        private bool[] vector; // вектор посещенных вершин

        public int Size { get; set; } // свойства
        public Node[] AdjList { get; set; }
        public bool[,] Adjacency { get; set; }
        public bool[] Vector { get; set; }

        public Graph(int size) // конструктор
        { // создание и инициализация списка смежности вершин графа
            AdjList = new Node[size];
            for (int i = 0; i <= size; i++) AdjList[i] = null;
        }
        public Graph(int size, bool[,] G) // конструктор класса «Графы»
        {
            Adjacency = new bool[size, size]; // инициализация матрицы смежности
            Adjacency = G;
            Vector = new bool[size];
            for (int i = 0; i < size; i++) Vector[i] = false; // иниц-я вектора посещенных вершин
            Size = size;
        }
        public void Depth(int i) //i – вершина, с которой начинается обход
        {
            Vector[i] = true; // отметить вершину i как обработанную
            Console.Write("{0}" + ' ', i); // распечатать номер посещенной вершины
            for (int k = 0; k < Size; k++) if (Adjacency[i, k] && !(Vector[k])) Depth(k); // перейти к обработке вершины k
        }
    }
}

