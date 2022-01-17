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

namespace wpfbmi
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

        private void rstbutton_Click(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            vysledek.Text = "";
        }

        private void vpctbutton_Click(object sender, RoutedEventArgs e)
        {
            double vyska = Convert.ToDouble(text1.Text);
            double vaha = Convert.ToDouble(text2.Text);
            double bmi = 0.0;


            bmi = vaha / Math.Pow(vyska / 100, 2);
            bmi = Math.Round(bmi);

           
            vysledek.Text = "Vaše BMI je: " + bmi;



        }
    }
}
