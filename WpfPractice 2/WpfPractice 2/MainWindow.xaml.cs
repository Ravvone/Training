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

namespace WpfPractice_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string entry = textBox.Text;

            label.Content = entry;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window1 wen = new Window1();
            wen.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window2 wen1 = new Window2();
            wen1.ShowDialog();
        }
    }
}
