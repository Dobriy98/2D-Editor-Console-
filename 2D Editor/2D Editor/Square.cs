using System;
using System.Collections.Generic;
using System.Text;

namespace _2D_Editor
{
    class Square : ICommand
    {
        int height = 0;
        int width = 0;
        int thickness = 1;
        ConsoleColor color;

        public Square(int height, int width, int thickness, ConsoleColor color)
        {
            this.height = height;
            this.width = width;
            this.thickness = thickness;
            this.color = color;
        }

        public void Redo()
        {
            Console.WriteLine($"Drow square with parameters: height {this.height}, width {this.width}, thickness {this.thickness}, color {this.color}");
            SaveManager.getInstance().AddStringToSave($"Drow square with parameters: height {this.height}, width {this.width}, thickness {this.thickness}, color {this.color}");
        }

        public void Undo()
        {
            Console.WriteLine($"Square removed");
            SaveManager.getInstance().RemoveString();
        }
    }
}
