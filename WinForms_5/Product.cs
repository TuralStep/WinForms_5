using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_5.Properties;

namespace WinForms_5
{
    public class Product
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Count { get; set; }
        public Bitmap Image { get; set; }

        public Product(string name, double cost, int count, Bitmap image)
        {
            Id = Guid.NewGuid();
            Name = name;
            Cost = cost;
            Count = count;
            Image = image;
        }
    }
}
