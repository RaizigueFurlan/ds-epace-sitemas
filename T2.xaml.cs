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
using System.Windows.Shapes;

namespace ATIVIDADE
{
    /// <summary>
    /// Lógica interna para T2.xaml
    /// </summary>
    public partial class T2 : Window
    {
        public T2()
        {
            InitializeComponent();
        }

        private void bt_adicao_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(tb_val_a.Text);
            double b = Convert.ToDouble(tb_valb.Text);
            double re = a + b;
            tb_result.Text = re.ToString();
        }

        private void bt_sibt_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(tb_val_a.Text);
            double b = Convert.ToDouble(tb_valb.Text);
            double re = a - b;
            tb_result.Text = re.ToString();
        }

        private void bt_div_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(tb_val_a.Text);
            double b = Convert.ToDouble(tb_valb.Text);
            double re = a * b;
            tb_result.Text = re.ToString();
        }

        private void bt_div1_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(tb_val_a.Text);
            double b = Convert.ToDouble(tb_valb.Text);
            double re = a / b;
            tb_result.Text = re.ToString();
        }

        private void tb_result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bt_apagar_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Clear();
            tb_val_a.Clear();       
            tb_valb.Clear();
            
        }
    }
}
