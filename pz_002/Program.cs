namespace graph2
{
    internal class Program
    {
        static Random uuu;
        static void Main(string[] args)
        {
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

            bool[,] M = new bool[4, 4]
                                        {
                                        {false, true, false, true}, // матрица смежности графа G4
                                        {true, false, false, false},
                                        {true, true, false, true},
                                        {false, true, false, false}
                                        };
            Graph graph = new Graph(4, M);
            graph.Depth(2);
        }
    }
}