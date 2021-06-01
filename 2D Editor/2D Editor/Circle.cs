using System;

namespace _2D_Editor
{
	public class Circle : ICommand
	{
		int radius = 1;
		int thickness = 1;
		ConsoleColor color;
		public Circle(int radius, int thickness, ConsoleColor color)
		{
			this.radius = radius;
			this.thickness = thickness;
			this.color = color;
		}

		public void Redo()
		{
			Console.WriteLine($"Drow circle with parameters: radius {this.radius}, thickness {this.thickness}, color {this.color}");
			SaveManager.getInstance().AddStringToSave($"Drow circle with parameters: radius {this.radius} thickness {this.thickness}, color {this.color}");
		}

		public void Undo()
		{
			Console.WriteLine($"Circle removed");
			SaveManager.getInstance().RemoveString();
		}
	}
}

