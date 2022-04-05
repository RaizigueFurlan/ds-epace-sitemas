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

namespace ATIVIDADE
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fechar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nome_usuario_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void btconfir_Click(object sender, RoutedEventArgs e)
        {

            string senha = pbsenha.Password.ToString();
            string usuario = txyusuario.Text;

            if (usuario == "raizigue" && senha =="123456")
            {
                T2 obj = new T2();
                obj.ShowDialog();
            }

          

            txyusuario.Clear(); 
            pbsenha.Clear();    

            

        }


        private void pbsenha_Click_PasswordChanged(object sender, RoutedEventArgs e)
        {
          
        }

        private void enter(object sender, EventArgs e)
        {

        }
    }
}
