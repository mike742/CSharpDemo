using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
// using System.Text.Json;

namespace Json_Xml_demo
{
    public class Item
    {
        public string id { set; get; }
        public string label { set; get; }
    }

    public class Menu 
    {
        public string header { set; get; }
        public List<Item> items { set; get; }
    }

    public class Top
    {
        public Menu menu { set; get; }

        public void Print()
        {
            Console.WriteLine(menu.header);

            foreach (var item in menu.items)
            {
                Console.WriteLine("\t");

                if (item != null) 
                {
                    if (item.id != null)
                        Console.Write(" id = " + item.id);
                    if (item.label != null)
                        Console.Write(" label = " + item.label);
                }
                else
                {
                    Console.WriteLine("\t null");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // string json = Console.ReadLine();

            string json = File.ReadAllText("data.json");

            // Top obj = JsonSerializer.Deserialize<Top>(json);
            // obj.Print();

            Top obj = JsonConvert.DeserializeObject<Top>(json);
            obj.Print();

            Console.WriteLine("\n==========================================\n");

            XmlDocument xmlDoc = JsonConvert.DeserializeXmlNode(json);
            // xmlDoc.Save("data.xml");
            xmlDoc.Save(Console.Out);
        }
    }
}
