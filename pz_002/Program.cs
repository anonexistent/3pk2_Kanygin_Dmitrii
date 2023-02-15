using System.Drawing;

namespace graph2
{
    internal class Program
    {
        public static Random uuu;

        public static void Print(object a)
        {
           Console.ForegroundColor = ConsoleColor.Red;
           Console.BackgroundColor = ConsoleColor.White;
           Console.WriteLine(a.ToString());
           Console.ResetColor();
        }

        /*
         1 найти самый дешевый узел
         2 обновить стоимость его соседей
         3 повторять для всех узлов
         4 результат
         */

        public static Node? FindLowestCostNode(Node[] n)
        {
            Node result = new Node(-1,int.MaxValue);

            foreach (var item in n) if(item.Weight<result.Weight) result = item;

            return result.Weight == int.MaxValue ? null : result;
        }

        public static void Dijkstra(Graph g)        //  еще что то про родителей
        {
            int currentWeight = 0;
            int newWeight = 0;
            List<Node> neighbors = new();

            List<int> weights = new();
            for (int i = 0; i < g.Size; i++) weights.Add(g.AdjList[i].Weight);

            Node a = FindLowestCostNode(g.AdjList);

            while (a!=null)
            {
                currentWeight = weights[a.Id];
                neighbors = a.Link;

                foreach (var item in neighbors)
                {
                    newWeight = currentWeight + item.Weight;
                    if (weights[a.Id] > newWeight)
                    {
                        weights[a.Id] = newWeight;
                    }
                }
                g.Vector[a.Id] = true;

                a = FindLowestCostNode(g.AdjList);
            }

            Console.WriteLine(currentWeight + " " + newWeight + "\n" + String.Join(';', neighbors.Select(x=>x.Weight)));
        }

        public static void DFS(Graph graph, int node)
        {
           graph.Vector[node] = true; // отметить вершину i как обработанную
           Console.Write("{0}" + ' ', node); // распечатать номер посещенной вершины
           for (int k = graph.Size-1; k >= 0; k--)
           {
                if (graph.Adjacency[node, k] && !(graph.Vector[k])) DFS(graph,k);
           }
        }

        static void Main(string[] args)
        {
            uuu = new();

            #region comm

            ///*        неориент
            //       а  б  в  г
            //    а  0  1  1  1
            //    б  1  0  1  0
            //    в  1  1  0  0
            //    г  1  0  0  0

            // */

            //bool[,] adjacency = { {false,true,true,true},
            //                      {true,false,true,false},
            //                      {true,true,false,false},
            //                      {true,false,false,false} };

            //Graph work = new(4);
            //for (int i = 0; i < work.Size; i++)
            //{
            //    work.AdjList[i] = new(i, uuu.Next(1,10));
            //    foreach (var item in adjacency)
            //    {

            //    }
            //}

            ///*
            //       а  б  в  г
            //    а  0  1  0  1
            //    б  1  0  0  0
            //    в  1  1  0  1
            //    г  0  1  0  0

            // */
            #endregion

            #region grapghs
            //bool[,] M = new bool[4, 4]
            //                            {
            //                            {false, true, false, true}, // матрица смежности графа G4
            //                            {true, false, false, false},
            //                            {true, true, false, true},      //  неполносвяз
            //                            {false, true, false, false}
            //                            };
            //Graph graph = new Graph(4, M);
            ////graph.Depth(2);
            //DFS(graph, 0);

            //Console.WriteLine("\n——————————");

            //bool[,] N = new bool[4, 4]
            //                            {
            //                                {false, true, true, false}, // матрица смежности графа G41
            //                                {true, false, true, true},
            //                                {true, true, false, false},
            //                                {false, true, false, false}
            //                            };
            //Graph graph2 = new Graph(4, N);
            //DFS(graph2, 3);

            //Console.WriteLine("\n——————————");

            //bool[,] O = new bool[5, 5]
            //                {
            //                                {false, true, false,true,false}, // матрица смежности графа G5  -- неориент
            //                                {true,false,true,false,true},
            //                                {false,true,false,true,false},
            //                                {true,false,true,false,true},
            //                                {false,true,false,true,false}
            //                };
            //Graph graph3 = new Graph(5, O);
            //DFS(graph3, 2);
            #endregion
            
            Console.WriteLine("\n——————————");

            bool[,] O2 = new bool[5, 5]
                            {
                                            {false, false, false,true,false}, // матрица смежности графа G5.1  -- ориент
                                            {true,false,false,false,true},
                                            {false,true,false,true,false},
                                            {true,true,true,false,true},
                                            {false,false,false,true,false}
                            };
            Graph graph4 = new Graph(5, O2);

            Console.Write("\ndepth: ");
            DFS(graph4, 2);
            Console.WriteLine("\n\n\n");

            Dijkstra(graph4);
        }
    }
}