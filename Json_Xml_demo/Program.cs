using System;
using System.Collections.Generic;
using System.IO;

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

                if (item.id != null)
                    Console.Write(item.id);
                else if (item.label != null)
                    Console.Write(item.label);
                else {
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

            Console.WriteLine($"json : {json}");
        }
    }
}
