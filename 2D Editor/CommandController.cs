using System;
using System.Collections.Generic;

namespace _2D_Editor
{
    public class CommandController
    {
        List<ICommand> historyList = new List<ICommand>();
        int counter = 0;

        public void addCommand(ICommand cmd)
        {
            cmd.Redo();
            historyList.Add(cmd);
            counter++;
        }

        public void removeCommand(int n)
        {
            for(int i = 0; i < n; i++)
            {
                if(counter > 0)
                {
                    counter--;
                    historyList[counter].Undo();
                }
            }
        }
        public void redoCommand(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (counter < historyList.Count)
                {
                    historyList[counter].Redo();
                    counter++;
                }
            }
        }
    }
}
