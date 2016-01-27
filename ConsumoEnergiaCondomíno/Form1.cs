using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoEnergiaCondomíno
{
    public partial class Form1 : Form
    {
        private IList<Leitura> leituras = new BindingList<Leitura>();
        private BindingSource leiturasSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            leiturasSource.DataSource = leituras;
            dataGridView.DataSource = leiturasSource;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            RemoveLineTotal();

            string casa;
            double consumo;

            if (textBoxNCasa.Text == String.Empty)
            {
                MessageBox.Show("Preencha o número da casa!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            casa = textBoxNCasa.Text;

            if (textBoxConsumo.Text == String.Empty)
            {
                MessageBox.Show("Preencha o valor do consumo!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Double.TryParse(textBoxConsumo.Text, out consumo))
            {
                MessageBox.Show("Consumo não digitado no formato correto!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegistarConsumo(casa, consumo);
        }

        private void RemoveLineTotal()
        {
            if (leituras.Count == decimal.Zero)
                return;
            if (leituras.Last().Casa.Equals("Total"))
                leituras.Remove(leituras.Last());
        }

        private void RegistarConsumo(string casa, double consumo)
        {
            var leitura = new Leitura(casa, consumo);

            if (leituras.Contains(leitura))
            {
                MessageBox.Show("Leitura já realizada para essa casa!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                leituras.Add(leitura);
                InicializaFormulario();
            }                
        }

        private void InicializaFormulario()
        {
            textBoxConsumo.Clear();
            textBoxNCasa.Clear();
            labelTotal.Text = string.Empty;
            textBoxNCasa.Focus();            
        }      
        
        private void buttonProcessar_Click(object sender, EventArgs e)
        {
            RemoveLineTotal();

            double totalConsumo = 0, totalDesconto = 0;

            foreach(var leitura in leituras)
            {
                totalConsumo += leitura.Consumo;
                totalDesconto += leitura.Desconto;
            }      

            leituras.Add(new Leitura("Total", totalConsumo));
           
            dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[dataGridView.ColumnCount - 1].Value = totalDesconto;

            labelTotal.Text = "Total consumo com desconto: " + (totalConsumo - totalDesconto).ToString("N");

            //DataGridViewCell cell = dataGridView.Rows[0].Cells[0];
            //this.leituras.Add(new Leitura("Total", 0));

            //int lastLineIndex = dataGridView.Rows.Count - 1;
            //for (int i = 0; i < dataGridView.ColumnCount; i++)
            //{
            //    dataGridView.Rows[lastLineIndex]
            //    .Cells[i].Style.BackColor =
            //    Color.Blue;
            //    dataGridView.Rows[lastLineIndex]
            //    .Cells[i].Style.ForeColor =
            //    Color.Yellow;
            //    dataGridView.Rows[lastLineIndex]
            //    .Cells[i].Style.Font =
            //    new Font(cell.InheritedStyle.Font,
            //    FontStyle.Bold);
            //}
            //double totalConsumo = 0, totalDesconto = 0;
            //foreach (var leitura in leituras)
            //{
            //    totalConsumo += leitura.Consumo;
            //    totalDesconto += leitura.Desconto;
            //}
            //dataGridView[0, lastLineIndex].Value = "Total";
            //dataGridView[1, lastLineIndex].Value = totalConsumo.ToString("N");
            //dataGridView[2, lastLineIndex].Value =
            //totalDesconto.ToString("N");
            //labelTotal.Text = "Total consumo sem desconto: " + (totalConsumo - totalDesconto).ToString("N");
        }
       
    }
}
