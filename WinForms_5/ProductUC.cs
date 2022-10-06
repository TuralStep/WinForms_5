using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_5
{
    public partial class ProductUC : UserControl
    {
        public ProductUC(Product p)
        {
            InitializeComponent();

            lbl_productCost.Text = p.Cost.ToString() + " AZN";
            cBox_productSay.Text = p.Count.ToString() + " eded";
            pBox_image.BackgroundImage = p.Image;

        }
    }
}
