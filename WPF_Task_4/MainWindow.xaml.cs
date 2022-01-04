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

namespace WPF_Task_4
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

        bool error;
        static double rate;
        static double sum;
        static double length;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            error = false;
            try
            {
                rate = Convert.ToDouble(rateDollar.Text);
                sum = Convert.ToDouble(sumDollar.Text);
            }
            catch (Exception ex)
            {
                resDollar.Text = "Ошибка ввода!";
                if (ex == null) error = false;
                else error = true;
            }
            if (!error)
            {
                double res = rate * sum;
                resDollar.Text = res.ToString() + " руб.";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            error = false;
            try
            {
                rate = Convert.ToDouble(rateEuro.Text);
                sum = Convert.ToDouble(sumEuro.Text);
            }
            catch (Exception ex)
            {
                resEuro.Text = "Ошибка ввода!";
                if (ex == null) error = false;
                else error = true;
            }
            if (!error)
            {
                double res = rate * sum;
                resEuro.Text = res.ToString() + " руб.";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            error = false;
            try
            {
                rate = Convert.ToDouble(rateGr.Text);
                sum = Convert.ToDouble(sumGr.Text);
            }
            catch (Exception ex)
            {
                resGr.Text = "Ошибка ввода!";
                if (ex == null) error = false;
                else error = true;
            }
            if (!error)
            {
                double res = rate * sum;
                resGr.Text = res.ToString() + " руб.";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            error = false;
            try
            {
                rate = Convert.ToDouble(rateDr.Text);
                sum = Convert.ToDouble(sumDr.Text);
            }
            catch (Exception ex)
            {
                resDr.Text = "Ошибка ввода!";
                if (ex == null) error = false;
                else error = true;
            }
            if (!error)
            {
                double res = rate * sum;
                resDr.Text = res.ToString() + " руб.";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            error = false;
            try
            {
                length = Convert.ToDouble(lenthInces.Text);
            }
            catch (Exception ex)
            {
                resInces.Text = "Ошибка ввода!";
                if (ex == null) error = false;
                else error = true;
            }
            if (!error)
            {
                double res = 0.0254 * length;
                resInces.Text = res.ToString() + " м";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            error = false;
            try
            {
                length = Convert.ToDouble(lenthFoots.Text);
            }
            catch (Exception ex)
            {
                resFoots.Text = "Ошибка ввода!";
                if (ex == null) error = false;
                else error = true;
            }
            if (!error)
            {
                double res = 0.3048 * length;
                resFoots.Text = res.ToString() + " м";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            error = false;
            try
            {
                length = Convert.ToDouble(lenthMiles.Text);
            }
            catch (Exception ex)
            {
                resMiles.Text = "Ошибка ввода!";
                if (ex == null) error = false;
                else error = true;
            }
            if (!error)
            {
                double res = 1609.344 * length;
                resMiles.Text = res.ToString() + " м";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            error = false;
            try
            {
                length = Convert.ToDouble(lenthVersts.Text);
            }
            catch (Exception ex)
            {
                resVersts.Text = "Ошибка ввода!";
                if (ex == null) error = false;
                else error = true;
            }
            if (!error)
            {
                double res = 1066.8 * length;
                resVersts.Text = res.ToString() + " м";
            }
        }
    }
}
