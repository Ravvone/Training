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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_1
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

        private double total1 = 0;
        private double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + "0";

        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + "4";
        }

        private void FIve_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + "9";
        }

        private void Period_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + ".";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = "";

        }

        private void p_Left_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + "(";
        }

        private void p_RIght_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = Screen.Text + ")";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 += double.Parse(Screen.Text);
            Screen.Text = "*";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 += double.Parse(Screen.Text);
            Screen.Text = "/";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 += double.Parse(Screen.Text);
            Screen.Text = "+";

            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            total1 = total1 += double.Parse(Screen.Text);
            Screen.Text = "-";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
        
            {
                if (plusButtonClicked == true)
                {
                    total2 = total1 + double.Parse(Screen.Text);
                    Screen.Text = total2.ToString();
                    total1 = 0;
                }
                else if (minusButtonClicked == true)
                {
                    total2 = total1 - double.Parse(Screen.Text);
                    Screen.Text = total2.ToString();
                    total1 = 0;
                }
                else if (multiplyButtonClicked == true)
                {
                    total2 = total1 * double.Parse(Screen.Text);
                    Screen.Text = total2.ToString();
                    total1 = 0;
                }
                else if (divideButtonClicked == true)
                {
                    total2 = total1 / double.Parse(Screen.Text);
                    Screen.Text = total2.ToString();
                    total1 = 0;
                }


        }   }
    }
}
