using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Json_Xml_demo
{
    [Serializable()]
    public class Customer : ISerializable
    {
        public string Name { set; get; }
        public string CreditCard { set; get; }
        public string Password { set; get; }

        public Customer() { }
        public Customer(SerializationInfo info, StreamingContext context) 
        {
            Name = info.GetValue("Name", typeof(string)).ToString();
            CreditCard = info.GetValue("CreditCard", typeof(string)).ToString();
            Password = info.GetValue("Password", typeof(string)).ToString();
        }
        
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("CreditCard", CreditCard);
            info.AddValue("Password", Password);
        }
    }
}
