using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    internal class Product:ISerializable
    {
        static int _id;
        public int Id { get;  }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Product()
        {
            _id++;
             Id = _id;
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("id", _id,typeof(Product));
            info.AddValue("name", Name, typeof(Product));
            info.AddValue("price",Price,typeof(Product));
            info.AddValue("description", Description,typeof(Product));
        }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Price: {Price} Description: {Description}";
        }
    }
}
