using System;
namespace _2D_Editor { 

public class Line : ICommand
{
	    int length = 0;
        int thickness = 1;
        ConsoleColor color;
        public Line(int length, int thickness, ConsoleColor color)
	    {
		    this.length = length;
            this.thickness = thickness;
            this.color = color;
	    }

        public void Redo()
        {
            Console.WriteLine($"Drow line with: length {this.length}, thickness {this.thickness}, color {this.color}");
            SaveManager.getInstance().AddStringToSave($"Drow line with: length {this.length}, thickness {this.thickness}, color {this.color}");
        }

        public void Undo()
        {
            Console.WriteLine("Line removed");
            SaveManager.getInstance().RemoveString();
        }
    }
}
