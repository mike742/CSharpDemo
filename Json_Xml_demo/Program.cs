using Newtonsoft.Json;
// using Shapes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
// using System.Text.Json;

namespace Json_Xml_demo
{
    [Serializable]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Square))]
    public class Shape
    {
        [XmlElement]
        public virtual string Name { get; }
        [XmlElement]
        public virtual double Area { get; }
        [XmlElement]
        public virtual string Color { get; set; }
    }
    [Serializable]
    public class Rectangle : Shape
    {

        public double Height { set; get; }
        public double Width { set; get; }

        public override string Color { get => base.Color; set => base.Color = value; }
        public override string Name => GetType().Name;
        public override double Area => Height * Width;
    }

    [Serializable]
    public class Square : Shape
    {
        public double Size { set; get; }

        public override string Color { get => base.Color; set => base.Color = value; }
        public override double Area => Size * Size;
        public override string Name => GetType().Name;
    }
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
            /*
            XmlDocument xmlDoc = JsonConvert.DeserializeXmlNode(json);
            // xmlDoc.Save("data.xml");
            xmlDoc.Save(Console.Out);
            */

            // IDisposable
            using (StringWriter sw = new StringWriter( new StringBuilder() ))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Top));
                xmlSerializer.Serialize(sw, obj);
                File.WriteAllText("data2.xml", sw.ToString());
            }

            string xmlString = File.ReadAllText("data2.xml");
            Top objFromXml = new Top();
            using (StringReader sr = new StringReader(xmlString))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Top));
                objFromXml = (Top)xmlSerializer.Deserialize(sr); // as Top
            }

            Console.WriteLine("\n================= Obj 2 from XML =========================\n");
            // objFromXml.Print();


            ToXml(obj, "dddd.xml");

            Top objFromXml2 = FromXml<Top>("dddd.xml");
            objFromXml2.Print();

            Console.WriteLine("\n================= Shapes =========================\n");

            List<Shape> list = new List<Shape>
            { 
                new Rectangle {  Color = "Blue", Height = 5, Width = 7 },
                new Square { Color = "Black", Size = 10 },
                new Rectangle {  Color = "Red", Height = 3, Width = 6 }
            };

            string xmlShapesPath = "shapes.xml";
            ToXml(list, xmlShapesPath);

            List<Shape> loadedShapesXml = FromXml<List<Shape>>(xmlShapesPath);

            foreach (var item in loadedShapesXml)
            {
                Console.WriteLine($"{item.Name} is {item.Color} has {item.Area}");
            }





            string key = Cripto.Cripto.GenerateSecretString();
            Console.WriteLine($"secretString = {key}");
            
            // string key = "n]1_xb:KTKC3^HW5A?kqRD<0>41X:?kt";
            string creditCard = "1234-5678-9012-3456";

           

            string hiddenCreditCard = Cripto.Cripto.EncryptString(key, creditCard);

            Console.WriteLine($"one time hidden = {Cripto.Cripto.toMD5(hiddenCreditCard)}");

            Console.WriteLine($"hiddenCreditCard = {hiddenCreditCard}");

            string decriptedCreditCard = Cripto.Cripto.DecryptString(key, hiddenCreditCard);

            Console.WriteLine($"decriptedCreditCard = {decriptedCreditCard}");

            string password = "Pa$$w0rd";
            Console.WriteLine($"SaltAndHashed password = {Cripto.Cripto.SaltAndHash(password)}");



            // Question #2

            List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Bob Smith", CreditCard = "1234-5678-9012-3456", Password = "Pa$$w0rd" },
                new Customer { Name = "Lucy Johnson", CreditCard = "5252-5678-7845-3456", Password = "123456" },
                new Customer { Name = "Mary Doe", CreditCard = "7899-7777-1234-3456", Password = "admin123" },
            };

            foreach (var item in customers)
            {
                item.CreditCard = 
                    Cripto.Cripto.EncryptString(key, item.CreditCard);
                item.Password =
                    Cripto.Cripto.SaltAndHash(item.Password);
            }

            ToXml(customers, "customers.xml");

            var customersFromXml = FromXml<List<Customer>>("customers.xml");

            Console.WriteLine("===========================================");
            foreach (var item in customersFromXml)
            {
                var ccn = Cripto.Cripto.DecryptString(key, item.CreditCard);
                Console.WriteLine($"{item.Name} { ccn } {item.Password}");
            }


            Console.WriteLine("============= Binary Serialization =================");

            ToBinary(customers, "customers.dat");

            using (Stream st = File.Open("customers.dat", FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();

                List<Customer> customersFromBinaryFile = 
                    bf.Deserialize(st) as List<Customer>;

                foreach (var item in customersFromBinaryFile)
                {
                    Console.WriteLine($"{item.Name}  {creditCard}");
                }
            }
        }

        public static void ToBinary<T>(T obj, string path)
        {
            using (Stream st = File.Open(path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(st, obj);
            }
        }
        public static void ToXml<T>(T obj, string path)
        {
            using (StringWriter sw = new StringWriter(new StringBuilder()))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(sw, obj);
                File.WriteAllText(path, sw.ToString());
            }
        }

        public static T FromXml<T>(string path)
        {
            string xmlString = File.ReadAllText(path);
            using (StringReader sr = new StringReader(xmlString))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(sr); 
            }
        }
    }
}
