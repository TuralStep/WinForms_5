using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_5.Classes
{
    public class Receipt
    {

        public Guid Id { get; set; }
        public List<Product> Products { get; set; }
        public double Mebleg { get; set; }
        public double Odenildi { get; set; }
        public double Qaliq { get; set; }

        public Receipt()
        {
            Id = Guid.NewGuid();
            Products = new List<Product>(1);
        }


        public void AddProduct(Product p)
        {
            Products.Add(p);
        }

        public void RemoveProduct(Product p)
        {
            Products.Remove(p);
        }


        public string GetReceiptString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("------------------------------\n");
            sb.Append($"Sizin cek : \n");
            sb.Append("------------------------------\n");

            foreach (var item in Products)
            {
                sb.Append($"{item.Name}\t{item.Cost}\n");
            }

            sb.Append("------------------------------\n");
            sb.Append($"Mebleg : {Mebleg}\n");
            sb.Append($"Odenildi : {Odenildi}\n");
            sb.Append($"Qaliq : {Qaliq}\n");
            sb.Append("------------------------------\n");

            return sb.ToString();
        }

    }
}
