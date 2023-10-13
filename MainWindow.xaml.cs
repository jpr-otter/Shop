using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JansCornerStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShoppingCart cart = new ShoppingCart();

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Window_Initialized(object sender, EventArgs e)
        {

        }

        
        private void BananeButton_Click(object sender, RoutedEventArgs e)
        {
            // Artikel in Shoppingcart
            
            Product Banane = new Product("1","Banane",0.5M, 5, 200.0,"16.10.2023","dfaskjisdgakjgsadkl") ;
            cart.AddProduct(Banane);
            UpdateListBox();

        }

        private void ApfelButton_Kopieren_Click(object sender, RoutedEventArgs e)
        {
            Product Apfel = new Product("1", "Apfel", 0.5M, 5, 200.0, "16.10.2023", "234234234");
            cart.AddProduct(Apfel);
            UpdateListBox();
        }

        private void ImbereButton_Kopieren1_Click(object sender, RoutedEventArgs e)
        {
            ShoppingCartListbox.Items.Add("");
            TotalSumLabel.Content = ShoppingCartListbox.Items.Count;
        }

        private void leMelonButton_Kopieren2_Click(object sender, RoutedEventArgs e)
        {
            ShoppingCartListbox.Items.Add("");
            TotalSumLabel.Content = ShoppingCartListbox.Items.Count;
        }

        private void CourgetteButton_Kopieren3_Click(object sender, RoutedEventArgs e)
        {
            ShoppingCartListbox.Items.Add("");
            TotalSumLabel.Content = ShoppingCartListbox.Items.Count;
        }

        private void UpdateListBox()
        {
            ShoppingCartListbox.Items.Clear();
            
            foreach(var Entry in cart.Entries)
            {
                ShoppingCartListbox.Items.Add(Entry);
            }
            TotalSumLabel.Content = cart.CalculateTotalPrice();
        }  

        private void RemoveOneItemOfAGroup_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = (Product)ShoppingCartListbox.SelectedItem;
            
            if (ShoppingCartListbox.SelectedItems != null)
            {
                cart.RemoveProduct();
                UpdateListBox();
            }
        }
    }
}
