using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace _2D_Editor
{
    public class SaveManager
    {
        private static SaveManager instance;
        private int index = 0;
        public List<string> stringsToSave = new List<string>();

        public static SaveManager getInstance()
        {
            if (instance == null)
                instance = new SaveManager();
            return instance;
        }

        public void SaveCommands()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<string>));
            if (File.Exists("savedCommands.xml")) File.Delete("savedCommands.xml");
            using (var file = new FileStream("savedCommands.xml", FileMode.OpenOrCreate))
            {
                ser.Serialize(file, stringsToSave);
            }
        }

        public List<string> LoadCommands()
        {
            using (var file = new FileStream("savedCommands.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<string>));
                return (List<string>)ser.Deserialize(file);
            }
        }

        public void AddStringToSave(string stringToSave)
        {
            stringsToSave.Add(stringToSave);
            index++;
        }

        public void RemoveString()
        {
            if(index > 0)
            {
                stringsToSave.RemoveAt(index - 1);
                index--;
            }
        }
    }
}
