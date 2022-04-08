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

namespace EscolaProjeto
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nomeFantasia, razaoSocial, CNPJ, inscricaoEstadual, tipo, rua, numero, bairro, cep, cidade, estado, responsavel, telefoneResponsavel, dataCriacao;

            nomeFantasia = txtNomeFantasia.Text;
            razaoSocial = txtRazaoSocial.Text;
            CNPJ = txtCNPJ.Text;
            inscricaoEstadual = txtInscEstadualPadding.Text;
            rua = txtRua.Text;
            numero = txtNumero.Text;
            bairro = txtBairro.Text;    
            cep = txtCep.Text;
            cidade = txtCidade.Text;
            estado = estadoCB.Text;
            responsavel = txtResponsavel.Text;
            telefoneResponsavel = txtTelResponsavel.Text;
            dataCriacao = DTcriacao.Text;

            if (tipoPublicaRB.IsChecked == true)
                tipo = "publica";
            else
                tipo = "privada";

            MessageBox.Show($"Nome fantásia: {nomeFantasia}\n Razão Social: {razaoSocial}\n CNPJ: {CNPJ}\n Inscrição Estadual: {inscricaoEstadual}\n Rua: {rua}\n Número: {numero}\n Bairro: {bairro}\n Cep: {cep}\n Cidade: {cidade}\n Estado: {estado}\n Responsável: {responsavel}\n Telefone do responsável: {telefoneResponsavel}\n Data da criação: {dataCriacao}\n");
           
        }
    }
}
