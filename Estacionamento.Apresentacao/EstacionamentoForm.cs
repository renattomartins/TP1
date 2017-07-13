using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estacionamento.Service;

namespace Estacionamento.Apresentacao
{
    public partial class EstacionamentoForm : Form
    {
        public EstacionamentoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string placa = textBox1.Text;

            try
            {

                Estacionamento.Service.EstacionamentoService proxy = new Estacionamento.Service.EstacionamentoService();

                proxy.Checkin(placa);

                MessageBox.Show(String.Format("Placa '{0}' adicionada.", placa));
                textBox1.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string placa = textBox1.Text;

            try
            {
                Estacionamento.Service.EstacionamentoService proxy = new Estacionamento.Service.EstacionamentoService();

                var valor = proxy.Checkout(placa);

                MessageBox.Show(String.Format("Placa '{0}' valor de R${1}.", placa, valor));
                textBox1.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EstacionamentoService proxy = new EstacionamentoService();

            int vagasRestantes = proxy.VagasRestantes();

            MessageBox.Show(String.Format("Número de vagas restantes: {0}", vagasRestantes));
        }
    }
}