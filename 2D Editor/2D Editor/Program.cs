using System;
using System.Collections.Generic;

namespace _2D_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = SaveManager.getInstance().LoadCommands();
            if(data != null)
            {
                foreach(string shape in data)
                {
                    Console.WriteLine(shape);
                }
            }
            Console.WriteLine();

            CommandController cc = new CommandController();
            ICommand square = new Square(5, 10, 2, ConsoleColor.Red);
            ICommand line = new Line(3, 1, ConsoleColor.Blue);
            ICommand circle = new Circle(3, 2, ConsoleColor.Green);

            cc.addCommand(square); //Создание команд
            cc.addCommand(line);
            cc.addCommand(circle);


            cc.removeCommand(2);//Отменить команды
            cc.redoCommand(2);//Повторить последние команды

            SaveManager.getInstance().SaveCommands();


        }
    }
}
