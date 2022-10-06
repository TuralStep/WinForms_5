using WinForms_5.Properties;

namespace WinForms_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Product> products = new()
            {
                new Product("Coca-Cola", 1.20, 15, Resources.kola_logo),
                new Product("Fanta", 1.10, 21, Resources.fanta_logo),
                new Product("Sprite", 1.00, 6, Resources.sprite_logo),
                new Product("Coca-Cola", 1.50, 35, Resources.snickers_logo)
            };

            for (int i = 0; i < products.Count; i++)
            {
                panel_products.Controls.Add(new ProductUC(products[i]));
            }

        }


    }
}