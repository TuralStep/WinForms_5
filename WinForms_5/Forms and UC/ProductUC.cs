
namespace WinForms_5
{
    public partial class ProductUC : UserControl
    {
        public ProductUC(Product p,System.EventHandler check)
        {
            InitializeComponent();

            lbl_productCost.Text = p.Cost.ToString() + " AZN";
            cBox_productSay.Text = p.Count.ToString() + " eded";
            cBox_productSay.CheckedChanged += check;
            pBox_image.BackgroundImage = p.Image;
            MyProduct = p;

        }

        public Product MyProduct { get; set; }

    }
}
