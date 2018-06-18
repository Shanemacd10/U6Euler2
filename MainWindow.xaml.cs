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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double n = 4000000;
        double total;
        public MainWindow()
        {
            InitializeComponent();
            //rearranged Binet theorem to find the largest term value in the sequence below n
            //then divides it by 3 since every third number in the sequence is even
            //thus giving me the total amount of even terms that are below the value of n
            //I then added this number and the terms before
            //they were calculated for each value of i which was multiplied by 3 because I previously divided the value by 3
            for (int i =1; i <= Math.Floor(((Math.Log(n) + (Math.Log(5)/2))/ Math.Log((1+ Math.Sqrt(5))/2))/3); i++)
            {
                total += (Math.Pow((1 + Math.Sqrt(5)) / 2, 3*i) - Math.Pow((1 - Math.Sqrt(5)) / 2, 3*i)) / Math.Sqrt(5);
            }
            MessageBox.Show(total.ToString());
        }
    }
}
