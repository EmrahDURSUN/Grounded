using System;
using System.IO;

namespace GrouındCreaTOR
{
    class Program
    {
        private const int givenDiameter = 1;
        private const int givenForce = 100;
        private const int givenDiameter2 = 3;
        private const int givenForce2 = 200;
        private const int givenDiameter3 = 5;
        private const int givenForce3 = 300;

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter width");
            //int XWidth = Convert.ToInt32(Console.In.ReadLine());
            //Console.WriteLine("Enter height");
            //int YHeight = Convert.ToInt32(Console.In.ReadLine());
            //Console.WriteLine("Enter depth");
            //int ZDepth = Convert.ToInt32(Console.In.ReadLine());
            //Console.WriteLine("Enter Node Size");
            //int NodeSize = Convert.ToInt32(Console.In.ReadLine());

            int XWidth = 120;
            int YHeight = 80;
            int ZDepth = 100;
            int NodeSize = 20;

            //int XWidth = 100;
            //int YHeight = 100;
            //int ZDepth = 100;
            //int NodeSize = 20;

            Console.WriteLine(XWidth + " " + YHeight + " " + ZDepth + " " + NodeSize);

            // CALCULATION TOTAL NUMBER OF POINT
            int XSize = 1;
            int XSteps = (XWidth + NodeSize) / NodeSize;

            int YSize = XSteps;
            int YSteps = ((YHeight + NodeSize) / NodeSize);

            int ZSize = ((YHeight + NodeSize) / NodeSize) * XSteps;
            int ZSteps = (ZDepth + NodeSize) / NodeSize;

            int TotalNumberOfPoints = XSteps * YSteps * ZSteps;

            Console.WriteLine("Xsize= " + XSize + "\n XSteps=" + XSteps + "\n YSize=" + YSize + "\n YSteps=" + YSteps + "\n ZSize=" + ZSize + "\n ZSteps=" + ZSteps + "\n Total Number Of Points=" + TotalNumberOfPoints);

            //int CalStartPoint = 0;
            //int CalEndPoint = 0;
            var filePath = @"E:\A\P2\csv1new01.csv";
            Console.WriteLine("Hello World 1 ");

            // X DIRECTION INCREASE
            using FileStream fs1 = new FileStream(filePath, FileMode.Append);
            {
                using StreamWriter sw = new StreamWriter(fs1);
                {

                    int CenterStart = XSteps * (YSteps + 1) + 2;

                    int rowY = YSteps - 2;
                    int columnX = XSteps - 2;
                    int plane = ZSteps - 2;
                    Console.WriteLine("Depth= " + plane + " Rows = " + rowY + " Columns = " + columnX);
                    
                    int[,,] grid = new int[plane, rowY, columnX ];

                    

                    for (int i = 0; i < plane; i++)
                    {
                        for (int j = 0; j <rowY ; j++)
                        {
                            for (int k = 0; k < columnX ; k++)
                            {
                                grid[i, j, k] = CenterStart;
                                CenterStart++;
                                Console.Write(grid[i, j, k] + " ; ");
                            }
                            CenterStart = CenterStart + 2;
                            Console.WriteLine(" X OVER " + CenterStart);
                        }
                        CenterStart = CenterStart + (2*YSize);
                        Console.WriteLine(" PLANE Completed ");
                    }


                    //for (int a = 0; a < plane; a++)
                    //{
                    //    for (int b = 0; b < rowY; b++)
                    //    {
                    //        for (int c = 0; c < columnX  ; c++)
                    //        {
                    //            //int one = grid[a, b, c]-X;
                    //            //int two = grid[a, b, c]-Y;
                    //            //int three = grid[a, b, c]-Z;
                    //            Console.Write(grid[a, b, c] + " ; ");

                    //            //Console.WriteLine(grid[a, b, c] + " ; " + one );
                    //            //Console.WriteLine(grid[a, b, c] + " ; " + two );
                    //            //Console.WriteLine(grid[a, b, c] + " ; " + three );
                    //        }
                    //        Console.WriteLine();
                    //        Console.WriteLine(" Row Over ");
                            
                    //    }
                    //    Console.WriteLine(" Plane Copleted");
                    //}
                }
            }
        }
    }
}
