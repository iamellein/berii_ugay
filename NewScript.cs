using Godot;
using System;
using System.Text;

public partial class NewScript : Node
{
	int[][] matrix = new int[10][];

	public override void _Ready()
	{
		// Initialize the matrix
		for (int i = 0; i < 10; i++)
		{
			matrix[i] = new int[10];
			for (int u = 0; u < 10; u++)
			{
				matrix[i][u] = (i + 1) * (u + 1);
			}
		}

		// Print the matrix horizontally (by columns)
		for (int col = 0; col < 10; col++)
		{
			StringBuilder rowBuilder = new StringBuilder();
			for (int row = 0; row < 10; row++)
			{
				rowBuilder.AppendFormat("{0,4}", matrix[row][col]);
			}
			GD.Print(rowBuilder.ToString());
		}
	}
}
