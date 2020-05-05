using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
		int XSteps = 7;
		int YSteps = 5;
		int ZSteps = 4;
		
		int X = 1;
		int Y = 7;
		int Z = 35;
		
		int CenterStart = XSteps*(YSteps+1)+2;
		
		int rows = YSteps-2;
		int columns = XSteps-2;
		int depths = ZSteps-2;
	
		int[,,] grid = new int[rows,columns,depths];
		
		
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < columns; j++)
			{
				for (int k = 0; k < depths; k++)
				{
					grid[i, j, k] = CenterStart;
					CenterStart++;
				}
				CenterStart = CenterStart + 2;
			}
			CenterStart = CenterStart + Z;
		}
				
		
        for (int a = 0; a < rows; a++)
		{
			for (int b = 0; b < columns; b++)
			{
				for (int c = 0; c < depths; c++)
				{
				int one = grid[a, b, c]-X;
				int two = grid[a, b, c]-Y;
				int three = grid[a, b, c]-Z;
			 
			 
				Console.WriteLine(grid[a, b, c] + " ; " + one );
				Console.WriteLine(grid[a, b, c] + " ; " + two );
				Console.WriteLine(grid[a, b, c] + " ; " + three );
				}
				Console.WriteLine();
			}
		}
	}	
}