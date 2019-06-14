/*
 * Conner Warboys
 * Project Euler Problem 48
 * May 12th, 2019
 * ICS3U
*/
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

namespace _185338SelfPowers
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            ulong Sum = 0;
            for(double i = 0; i < 1001; i++)
            {
                Sum += (ulong)Math.Pow(i,i);
            }
            lblOuput.Content = Sum;

            string temp = Sum.ToString();
            int startIndex = temp.Length - 10;
            lblLast10.Content = temp.Substring(startIndex);
        }
    }
}
