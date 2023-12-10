using ComputerShop.Models;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class Form1 : Form
    {
        private Category[] categories;
        private ObservableCollection<Product> products;

        public decimal TotalToPay
        {
            get
            {
                return cartListBox.Items.OfType<Product>().Sum(e => e.Price);
            }
        }

        public Form1()
        {
            InitializeComponent();
            categories = new Category[]
            {
                new Category{ Name = "Laptops"},
                new Category{ Name = "Headphones"},
                new Category{ Name = "Smartphones"},
                new Category{ Name = "Mouses"},
                new Category{ Name = "Monitors"},
                new Category{ Name = "Keyboards"},
                new Category{ Name = "Speakers"},
            };
            products = new ObservableCollection<Product>()
            {
                new Product{Name="Asus Vx18", Category = categories[0],Price=1200,Quantity=12 },
                new Product{Name="Acer Predator Helious 3700", Category = categories[0],Price=2050,Quantity=10 },
                new Product{Name="Lenovo XP450", Category = categories[0],Price=890,Quantity=32 },
                new Product{Name="HP Pavilion", Category = categories[0],Price=700,Quantity=20 },
                new Product{Name="Huawey HK45", Category = categories[1],Price=50,Quantity=40 },
                new Product{Name="Nokia 3310", Category = categories[1],Price=100,Quantity=70 },
                new Product{Name="Mobila 25", Category = categories[1],Price=70,Quantity=30 },
                new Product{Name="BabushkinPhone 4490", Category = categories[1],Price=42,Quantity=10 },
                new Product{Name="LG HA1210", Category = categories[2],Price=450,Quantity=12 },
                new Product{Name="Samsung A56", Category = categories[2],Price=300,Quantity=10 },
                new Product{Name="Apple P30", Category = categories[2],Price=550,Quantity=20 },
                new Product{Name="Lenovo D100", Category = categories[2],Price=730,Quantity=5 },
                new Product{Name="Predator 11", Category = categories[3],Price=12,Quantity=60 },
                new Product{Name="Logitech G306", Category = categories[3],Price=15,Quantity=40 },
                new Product{Name="Altech H5", Category = categories[3],Price=25,Quantity=15 },
                new Product{Name="China 80", Category = categories[3],Price=7,Quantity=25 },
                new Product{Name="Samsung Led3320", Category = categories[4],Price=756,Quantity=10 },
                new Product{Name="MSI 6010", Category = categories[4],Price=1020,Quantity=6 },
                new Product{Name="LG 5070", Category = categories[4],Price=560,Quantity=30 },
                new Product{Name="BlindScreen 15", Category = categories[4],Price=834,Quantity=42 },
                new Product{Name="Genius HX40", Category = categories[5],Price=42,Quantity=31 },
                new Product{Name="Altech Brokenbutton", Category = categories[5],Price=52,Quantity=21 },
                new Product{Name="Asus BendedLine", Category = categories[5],Price=25,Quantity=16 },
                new Product{Name="VeryChina Keyboard 1", Category = categories[5],Price=83,Quantity=24 },
                new Product{Name="VeryLoud squeak5", Category = categories[6],Price=75,Quantity=23 },
                new Product{Name="GoodBearSound", Category = categories[6],Price=86,Quantity=45 },
                new Product{Name="Samsung LastNightHere", Category = categories[6],Price=39,Quantity=20 },
                new Product{Name="LG StopItNow", Category = categories[6],Price=105,Quantity=36 },
            };

            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";

            FillListBox();
        }

        private void FillListBox()
        {
            itemsListBox.DataSource = products.Where(e => e.Category.Id.Equals(categoryComboBox.SelectedValue)).ToList();
        }

        private void UpdateCartBox()
        {
            //Product[] cartItems = cartListBox.Items.OfType<Product>().ToArray();
            //cartListBox.Items.Clear();
            for (int i = 0; i < cartListBox.Items.Count; i++)
            {
                cartListBox.Items[i] = products.FirstOrDefault(e => e.Equals(cartListBox.Items[i]));
            }
            totalToPayTextBox.Text = $"{TotalToPay.ToString()} $";
        }

        private void deleteFromCartButton_Click(object sender, EventArgs e)
        {
            int index = cartListBox.SelectedIndex;
            if (index != -1)
            {
                cartListBox.Items.RemoveAt(index);
                totalToPayTextBox.Text = $"{TotalToPay.ToString()} $";
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            var selectedProducts = itemsListBox.SelectedItems.OfType<Product>().ToArray();
            if (selectedProducts != null)
            {
                cartListBox.Items.AddRange(selectedProducts);
                totalToPayTextBox.Text = $"{TotalToPay.ToString()} $";
            }
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            var selectedProducts = itemsListBox.SelectedItems.OfType<Product>().ToArray();
            if (selectedProducts != null)
            {
                DetailsForm detailsForm = new DetailsForm(selectedProducts);
                var result = detailsForm.ShowDialog();
                FillListBox();
                UpdateCartBox();
            }
        }

        private void completeOrderButton_Click(object sender, EventArgs e)
        {
            if (TotalToPay > 0)
            {
                var orderedProducts = cartListBox.Items.OfType<Product>().ToArray();
                if (orderedProducts != null)
                {
                    PaymentForm paymentForm = new PaymentForm(orderedProducts, TotalToPay);
                    //paymentForm.Parent = this;
                    paymentForm.Left = this.Left;
                    paymentForm.Top= this.Top;
                    paymentForm.ShowDialog();
                    if(paymentForm.DialogResult == DialogResult.OK)
                    {
                        cartListBox.Items.Clear();
                    }
                }
            }
        }
    }
}
