using System.Text.Json;
using WinForms_5.Classes;
using WinForms_5.Properties;

namespace WinForms_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Receipt rec = new();
        double mebleg = 0;
        double odenildi = 0;
        double qaliq = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Product> products = JsonSerializer.Deserialize<List<Product>>(File.ReadAllText("Products.json"))!;

            for (int i = 0; i < products.Count; i++)
            {
                switch (products[i].Name)
                {
                    case "Coca-Cola":
                        products[i].Image = Resources.kola_logo;
                        break;
                    case "Fanta":
                        products[i].Image = Resources.fanta_logo;
                        break;
                    case "Sprite":
                        products[i].Image = Resources.sprite_logo;
                        break;
                    case "Snickers":
                        products[i].Image = Resources.snickers_logo;
                        break;
                    case "Tutku":
                        products[i].Image = Resources.tutku_logo;
                        break;
                    case "Albeni":
                        products[i].Image = Resources.albeni_logo;
                        break;
                    case "Mars":
                        products[i].Image = Resources.mars_logo;
                        break;
                    case "Lipton":
                        products[i].Image = Resources.lipton_ice_tea_logo;
                        break;
                }
                panel_products.Controls.Add(new ProductUC(products[i], CheckedChanged));
            }

        }


        private void CheckedChanged(object sender, EventArgs e)
        {
            mebleg = 0;
            foreach (ProductUC uc in panel_products.Controls)
            {
                if (uc.cBox_productSay.Checked)
                    mebleg += uc.lbl_productCost.Text.GetNumberFromString();
            }
            qaliq = odenildi - mebleg;
            SetPulLabelsTexts();
        }

        private void DefaultQiymetClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "qepik10":
                    odenildi += 0.1;
                    break;
                case "qepik20":
                    odenildi += 0.2;
                    break;
                case "qepik50":
                    odenildi += 0.5;
                    break;
                case "manat1":
                    odenildi += 1;
                    break;
                case "manat5":
                    odenildi += 5;
                    break;
                case "manat10":
                    odenildi += 10;
                    break;
            }
            qaliq = odenildi - mebleg;
            SetPulLabelsTexts();
        }

        private void getReceipt_Click(object sender, EventArgs e)
        {

            if (qaliq < 0)
            {
                MessageBox.Show("Aldiginiz esyalarin pulunu odemeden gede bilmezsiniz...",
                                "Diqqet",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return;
            }
            if (mebleg == 0)
            {
                MessageBox.Show("Hecne almadiginiz ucun cek yoxdur...",
                                "Informasiya",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            List<Product> products = JsonSerializer.Deserialize<List<Product>>(File.ReadAllText("Products.json"))!;
            foreach (ProductUC uc in panel_products.Controls)
            {
                if (uc.cBox_productSay.Checked)
                {
                    rec.AddProduct(uc.MyProduct);
                    products.Find(p => p.Name == uc.MyProduct.Name)!.Count--;
                    uc.MyProduct.Count--;
                    uc.cBox_productSay.Text = $"{uc.MyProduct.Count} eded";
                }
            }
            rec.Mebleg = mebleg;
            rec.Qaliq = qaliq;
            rec.Odenildi = odenildi;

            MessageBox.Show(rec.GetReceiptString());
            File.WriteAllText($"{rec.Id}.json", JsonSerializer.Serialize(rec));
            ClearAllText();

            File.WriteAllText("Products.json", JsonSerializer.Serialize(products));

        }


        private void txt_pul_TextChanged(object sender, EventArgs e)
        {
            bool isEnabled = txt_pul.Text.Equals("0");
            btn_10qep.Enabled = isEnabled;
            btn_20qep.Enabled = isEnabled;
            btn_50qep.Enabled = isEnabled;
            btn_1azn.Enabled = isEnabled;
            btn_5azn.Enabled = isEnabled;
            btn_10azn.Enabled = isEnabled;

            odenildi = 0;

            if (string.IsNullOrWhiteSpace(txt_pul.Text) || string.IsNullOrEmpty(txt_pul.Text))
                txt_pul.Text = "0";
            else if (txt_pul.Text[0] == '0' && txt_pul.Text.Length > 1)
                txt_pul.Text = txt_pul.Text.Remove(0, 1);
            else if (!txt_pul.Text.All(c => (c >= '0' && c <= '9') || c == '.'))
                txt_pul.Text = txt_pul.Text.Remove(txt_pul.Text.Length - 1, 1);
            txt_pul.SelectionStart = txt_pul.Text.Length;

            odenildi = Convert.ToDouble(txt_pul.Text);

            SetPulLabelsTexts();

        }


        private void SetPulLabelsTexts()
        {
            qaliq = odenildi - mebleg;
            lbl_daxil.Text = $"Daxil edilmis mebleg : {odenildi} AZN";
            lbl_qaliq.Text = $"Qaliq : {qaliq} AZN";
            lbl_cost.Text = $"Mebleg : {mebleg} AZN";
        }

        private void ClearAllText()
        {
            foreach (ProductUC item in panel_products.Controls)
            {
                item.cBox_productSay.Checked = false;
            }
            mebleg = 0;
            qaliq = 0;
            odenildi = 0;
            txt_pul.Text = "";
            SetPulLabelsTexts();
        }

    }
}