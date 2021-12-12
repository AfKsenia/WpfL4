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

namespace WpfL4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void ResEuro_Click(object sender, RoutedEventArgs e)
        {
            double rateEuros = Convert.ToDouble(rateEuro.Text);
            double sumEuros = Convert.ToDouble(sumEuro.Text);
            double resDoubleEuro = rateEuros * sumEuros;
            resSumEuro.Text = resDoubleEuro.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateHryvnias = Convert.ToDouble(rateHryvnia.Text);
            double sumHryvnias = Convert.ToDouble(sumHryvnia.Text);
            double resDoubleHryvnia = rateHryvnias * sumHryvnias;
            resSumHryvnia.Text = resDoubleHryvnia.ToString();
        }

        private void ResDram_Click(object sender, RoutedEventArgs e)
        {
            double rateDramas = Convert.ToDouble(rateDram.Text);
            double sumDramas = Convert.ToDouble(sumDram.Text);
            double resDoubleHryvnia = rateDramas * sumDramas;
            resSumDram.Text = resDoubleHryvnia.ToString();
        }

        private void BtnResInch_Click(object sender, RoutedEventArgs e)
        {
            double numberInch = Convert.ToDouble(inch.Text);
            double resDoubleInch = numberInch * 0.0254;
            resInch.Text = resDoubleInch.ToString();
        }

        private void BtnResFoot_Click(object sender, RoutedEventArgs e)
        {
            double numberFoot = Convert.ToDouble(foot.Text);
            double resDoubleFoot = numberFoot * 0.3048;
            resFoot.Text = resDoubleFoot.ToString();
        }

        private void BtnResMile_Click(object sender, RoutedEventArgs e)
        {
            double numberMile = Convert.ToDouble(mile.Text);
            double resDoubleMile = numberMile * 1609.34;
            resMile.Text = resDoubleMile.ToString();
        }

        private void BtnResVerst_Click(object sender, RoutedEventArgs e)
        {
            double numberVerst = Convert.ToDouble(verst.Text);
            double resDoubleVerst = numberVerst * 1066.8;
            resVerst.Text = resDoubleVerst.ToString();
        }


    }
}
