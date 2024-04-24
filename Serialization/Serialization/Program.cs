using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Xml.Serialization;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Test";
            product.Price = 10;
            product.Description = "Test";


            ProductToJson(product);

            Console.WriteLine(JsonToProduct());
          
            
           
        }

        public static void ProductToJson(Product product)
        {
            string path = "C:\\Users\\memme\\Desktop\\data.json";

          using  Stream stream = new FileStream(path,FileMode.Create);


            JsonSerializer.Serialize(stream, product);
        }

        public static Product JsonToProduct()
        {
            string path = "C:\\Users\\memme\\Desktop\\data.json";

            using Stream stream = new FileStream(path, FileMode.Open);

           return JsonSerializer.Deserialize<Product>(stream);

        }
    }
}
