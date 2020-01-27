using System;
using ProjetoJL.Repositorios;
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
using ProjetoJL_Lib.Repositorios;

namespace ProjetoJL
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

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now.Date;
            lblDataRegistro.Content = data;

            ProdutoRepositorio produto = new ProdutoRepositorio();
            cboProduto.ItemsSource = produto.ListarProduto();

            PesoRepositorio peso = new PesoRepositorio();
            cboPeso.ItemsSource = peso.ListarPeso();

            if (cboPeso.SelectedIndex == -1)
            {

            }
            if(cboPeso.SelectedIndex == 0)
            {
                cboPeso.SelectedIndex.ToString() = "1Kg";
            }


        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(cboPeso.SelectedIndex.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //ClienteRepositorio repo = new ClienteRepositorio();
            //dgCliente.ItemsSource = repo.Pesquisar(txtPesquisar.Text);
        }

        private void CboPeso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboPeso.Items.Count == 0)
            {
                
            }
        }
    }
}

