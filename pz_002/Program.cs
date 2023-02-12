using System.Drawing;

namespace graph2
{
    internal class Program
    {
        static Random uuu;

        public static void Print(object a)
        {
           Console.ForegroundColor = ConsoleColor.Red;
           Console.BackgroundColor = ConsoleColor.White;
           Console.WriteLine(a.ToString());
           Console.ResetColor();
        }

        public static void DFS(Graph graph, int node)
        {
           graph.Vector[node] = true; // отметить вершину i как обработанную
           Console.Write("{0}" + ' ', node); // распечатать номер посещенной вершины
           for (int k = 0; k < graph.Size; k++)
           {
                if (graph.Adjacency[node, k] && !(graph.Vector[k])) DFS(graph,k);
           }

        }

        static void Main(string[] args)
        {
            #region comm
            //uuu = new();

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

            bool[,] M = new bool[4, 4]
                                        {
                                        {false, true, false, true}, // матрица смежности графа G4
                                        {true, false, false, false},
                                        {true, true, false, true},
                                        {false, true, false, false}
                                        };
            Graph graph = new Graph(4, M);
            //graph.Depth(2);
            DFS(graph, 0);







            Console.ReadKey();
        }
    }
}