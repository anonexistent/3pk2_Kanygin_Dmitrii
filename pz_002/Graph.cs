using System.Numerics;

namespace graph2
{
    internal class Graph
    {
        private int size; // количество вершин в графе
        private Node[]? adjList; // ссылка на список смежности вершин графа
        private bool[,]? adjacency; // матрица смежности графа
        private bool[]? vector; // вектор посещенных вершин

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
            if (G.GetLength(0) == size && G.GetLength(1) == size)
            {
                adjList = new Node[size];
                Adjacency = new bool[size, size]; // инициализация матрицы смежности
                Adjacency = G;
                Vector = new bool[size]; 
                Size = size;
                for (int i = 0; i < size; i++) adjList[i] = new Node(i, Program.uuu.Next(0,10));
                for (int i = 0; i < size; i++)
                {
                    
                    Console.WriteLine("creating grapgh.." + new String('.', i));
                    Vector[i] = false;                  // иниц-я вектора посещенных вершин
                    for (int j = 0; j < size; j++)
                    {
                        Task.Delay(100);
                        //(G[i, j] == true ?  : null);

                        if (G[i, j] == true)
                        {
                            adjList[i].Link.Add(adjList[j]);
                            Console.WriteLine($"is road(link) from \t{i}\tto\t{j}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("something wrong! LEGO(конструктор) isn't work!!");
                size = -1;
                adjList = null;
                adjacency = null;
                vector = null;
            }
            
        }
        //public void Depth(int i) //i – вершина, с которой начинается обход
        //{
        //    Vector[i] = true; // отметить вершину i как обработанную
        //    Console.Write("{0}" + ' ', i); // распечатать номер посещенной вершины
        //    for (int k = 0; k < Size; k++) if (Adjacency[i, k] && !(Vector[k])) Depth(k); // перейти к обработке вершины k
        //}
    }
}

