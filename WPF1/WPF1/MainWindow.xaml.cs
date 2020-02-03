//Clay Sullivan
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

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textbox1.Text = string.Empty;
            textbox2.Text = string.Empty;
            textbox3.Text = string.Empty;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
                             
            
        }
        private void TextBox_TextChanged2(object sender, TextChangedEventArgs e)
        {
            

            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string addy = textbox1.Text;
            string namy = textbox2.Text;
            string zipy = textbox3.Text;
            int zipcode;

            if (string.IsNullOrWhiteSpace(addy)==true)
            {
                MessageBox.Show("You must enter an address");
            }

            bool isint = Int32.TryParse(zipy, out zipcode);
            if (isint==false)
            {
                MessageBox.Show("must enter an integer value for zip code");
            }

            EntryForm ef = new EntryForm();
            ef.address = addy;
            ef.name = namy;
            ef.zip = zipcode;

            // ^^ does the same thing as above EntryForm ef = new EntryForm(namy,addy,zipcode);
            listbox1.Items.Add(ef);

        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
            
        }

        private void textbox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
