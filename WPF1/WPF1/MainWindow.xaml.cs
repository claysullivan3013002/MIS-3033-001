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
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
                             
            
        }
        private void TextBox_TextChanged2(object sender, TextChangedEventArgs e)
        {
            

            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            EntryForm.name = textbox1.Text;
            string address = textbox2.Text;
            int zip = Convert.ToInt32(textbox3.Text);
            listbox1.Items.Add(EntryForm);
            listbox1.Items.Add(zip);
        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
            
        }

        private void textbox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
